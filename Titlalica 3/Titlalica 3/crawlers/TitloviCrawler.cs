using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titlalica_3.util;

namespace Titlalica_3.crawlers {

    /*
     * Class used to crawl site titlovi.com and provide list of search results
     * titlovi.com is used to search for serbian and croatian subtitles
     * */
    class TitloviCrawler {

        MainForm mainForm;
        HTMLUtils HTMLUtils;
        String title;
        String language;
        int totalTitles;
        int parsedSubs;

        public TitloviCrawler(MainForm caller) {
            this.mainForm = caller;
            this.HTMLUtils = new HTMLUtils(caller);
        }

        public void search(String title, String language) {
            List<Subtitle> subs = new List<Subtitle>();
            this.title = title;
            this.language = language;
            String searchUrl = "http://titlovi.com/titlovi/titlovi.aspx?prijevod=" + title + "&jezik=" + language + "&stranica=";

            HtmlAgilityPack.HtmlDocument document = HTMLUtils.getDocument(searchUrl + "1");
            int pages = 1;
            parsedSubs = 0;
            if (document != null) {
                pages = getPageNumber(document);
                totalTitles = getTotalSubtitleNumber(pages, document);
                for (int i = 1; i <= pages; i++) {
                    List<Subtitle> pageSubs = parsePage(i);
                    if (pageSubs.Count > 0) {
                        subs.AddRange(pageSubs);
                    }
                }
                mainForm.showSubs(subs);
            } else {
                mainForm.setStatus("Error occured! Check your internet connection.", Color.Red);
            }
            mainForm.resetCursor();
        }

        private List<Subtitle> parsePage(int pageNumber) {
            List<Subtitle> subs = new List<Subtitle>();
            String pageUrl ="http://titlovi.com/titlovi/titlovi.aspx?prijevod=" + title + "&jezik=" + language + "&stranica=1";
            HtmlDocument document = HTMLUtils.getDocument(pageUrl);
            if (document != null) {
                HtmlNode bodyNode = document.DocumentNode.SelectSingleNode("//body");
                if (bodyNode != null) {
                    ////table[@class='list first_column_title']/tbody/tr
                    //every subtitle is displayed in <li class="listing"> contained in <ul> within it
                    //all useful data is in <div> with class "title c1"
                    HtmlNodeCollection liNodes = bodyNode.SelectNodes("//li[@class='listing']/ul/li");
                    if (liNodes != null) {
                        foreach (HtmlNode node in liNodes) {
                            Subtitle subtitle = parseDiv(node);
                            if (subtitle != null) {
                                subs.Add(subtitle);
                                setProgress();
                            }
                        }
                    } 
                }
                return subs;
            } else {
                return null;
            }
        }

        //extract subtitle data from <div> element
        private Subtitle parseDiv(HtmlNode li) {
            Subtitle sub = null;
            //<div class='title c1'> contains title, number of discs and verions
            HtmlNode divC1 = li.SelectSingleNode("div[@class='title c1']");
            if (divC1 != null) {
                //get <h4> element which containes most of data
                HtmlNode h4Node = divC1.SelectSingleNode("h4[@class='info-popup']");
                if (h4Node != null) {
                    //<a> tag inside <h4> contains movie title, with its href points to download page
                    HtmlNode aNode = h4Node.SelectSingleNode("a");
                    String movieTitle = aNode.InnerText;
                    String downloadPage = HTMLUtils.getAttributeValue(aNode, "href");
                    //<span class='year'> contains year
                    HtmlNode yearNode = h4Node.SelectSingleNode("span[@class='year']");
                    movieTitle += yearNode.InnerText.Trim();
                    //<span class='cd'> contains number of discs
                    HtmlNode cdNode = h4Node.SelectSingleNode("span[@class='cd']");
                    String cdStr = cdNode.InnerText.Trim().Split(' ')[0];
                    int discs = Convert.ToInt32(cdStr.Trim());
                    //versions are displayed in <span class="release">, separated by /
                    HtmlNode releaseNode = divC1.SelectSingleNode("span[@class='release']");
                    String releases = "N/A";
                    if (releaseNode != null) {
                        releases = releaseNode.InnerText.Replace('/', '\n');
                    }
                    String fps = "N/A";
                    //<div class='meta c2'> contains fps
                    HtmlNode fpsSpan = li.SelectSingleNode("div[@class='meta c2']/span[@class='fps']");
                    if (fpsSpan != null) {
                        fps = fpsSpan.InnerText.Split(':')[1].Trim();
                    }
                    sub = new Subtitle(movieTitle, releases, downloadPage, fps, discs);
                }
            }
            return sub;
        }

        //increments total paresed subtitles count and sets status bar in main form
        private void setProgress() {
            parsedSubs++;
            double progress = ((double)parsedSubs / (double)totalTitles) * 100;
            mainForm.setProgress((int)progress);
        }

        //search for number of result pages
        private int getPageNumber(HtmlAgilityPack.HtmlDocument document) {
            int pages = 1;

            //link to each page is shown in one <li> element of <ul> list with 'clear pagination' class
            //so number of pages is number of such <li> tags
            HtmlNode bodyNode = document.DocumentNode.SelectSingleNode("//body");
            if (bodyNode != null) {
                HtmlNode pagesList = bodyNode.SelectSingleNode("//ul[@class='clear pagination']");
                if (pagesList != null) {
                    pages = pagesList.ChildNodes.Count - 1;
                }
            }
            return pages;
        }

        //gets exact number of found subtitles
        public int getTotalSubtitleNumber(int pages, HtmlDocument document) {
            //if parsing has failed, calculate aproximate number
            int total = (pages - 1) * 14;

            HtmlNode bodyNode = document.DocumentNode.SelectSingleNode("//body");
            if (bodyNode != null) {
                //find first <p> tag with 'msg' class and get number (third word) 
                HtmlNode message = bodyNode.SelectSingleNode("//p[@class='msg']");
                if (message != null) {
                    String numStr = message.InnerText.Split(' ')[2];
                    try {
                        total = Convert.ToInt32(numStr);
                    } catch {

                    }
                }
            }

            return total;
        }

    }
}
