using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Drawing;
using Titlalica_3.util;

namespace Titlalica_3.crawlers {
    /*
     * Class used to crawl site podnapisi.net and provide list of search results
     * podnapisi.net is used to search only for english subtitles
     * */
    class PodnapisiCrawler {

        MainForm mainForm;
        String title;
        String searchURL;
        HTMLUtils HTMLUtils;

        int pageCount;
        int parsedSubs;
        int subsPerPage = 50;

        public PodnapisiCrawler(MainForm caller, String movie) {
            HTMLUtils = new HTMLUtils(caller);
            this.mainForm = caller;
            this.title = movie;
            this.searchURL = "https://www.podnapisi.net/subtitles/search/advanced?keywords=" + 
                              title.Replace(" ", "+")  +
                              "&year=&seasons=&episodes=&language=en&page=";
        }

        public void search() {
            HtmlAgilityPack.HtmlDocument document = HTMLUtils.getDocument(searchURL + "1");
            if (document != null) {
                int pages = getPageNumbers(document);
                pageCount = pages;
                parsedSubs = 0;
                List<Subtitle> titls = new List<Subtitle>();
                if (pages > 0) {
                    for (int i = 1; i <= pages; i++) {
                        List<Subtitle> pageSubs = parsePage(i);
                        if (pageSubs != null) {
                            titls.AddRange(pageSubs);
                        }
                    }
                }
                mainForm.showSubs(titls);
            } else {
                mainForm.setStatus("Error occured! Check your internet connection.", Color.Red);
            }
            mainForm.resetCursor();
        }

        private List<Subtitle> parsePage(int pageNumber) {
            List<Subtitle> titles = new List<Subtitle>();

            HtmlAgilityPack.HtmlDocument document = HTMLUtils.getDocument(searchURL + pageNumber.ToString());

            if (document != null) {
                //subtitles are displayed in table with classes 'table table-striped table-hover'
                HtmlNode bodyNode = document.DocumentNode.SelectSingleNode("//body");
                if (bodyNode != null) {
                    HtmlNodeCollection rows = bodyNode.SelectNodes("//table[@class='table table-striped table-hover']/tbody/tr");
                    foreach (HtmlNode row in rows) {
                        Subtitle title = parseRow(row);
                        titles.Add(title);
                        setProgress();
                    }
                }
                return titles;
            } else {
                return null;
            }
        }

        //extracts subtitle data from table rows
        private Subtitle parseRow(HtmlNode row) {
            String title = "N/A", downloadURL = "N/A", FPS = "N/A", version = "N/A";
            int numberOfDiscs = 0;

            // Get all row cells
            HtmlNodeCollection cells = row.SelectNodes("td");

            // First cell contains movie title, download link, and a release
            HtmlNode firstCell = cells.ElementAt(0);
            if(firstCell != null) {
                HtmlNode downloadDiv = firstCell.SelectSingleNode("div[@class='pull-left']");
                if(downloadDiv != null) {
                    HtmlNode downloadLink = downloadDiv.SelectSingleNode("a[@alt='Download subtitles.']");
                    downloadURL = HTMLUtils.getAttributeValue(downloadLink, "href");
                }
                HtmlNode titleLink = firstCell.SelectSingleNode("a");
                if(titleLink != null) {
                    title = titleLink.InnerText;
                }
                // Movie version is in a span.release element
                // Currently, only one release is displayed, all others are lazy fetched by clicking a button on the website :(
                HtmlNode releaseSpan = firstCell.SelectSingleNode("span[@class='release']");
                if(releaseSpan != null) {
                    version = releaseSpan.InnerText;
                }
            }

            // Second cell contains FPS
            HtmlNode secondCell = cells.ElementAt(1);
            if(secondCell != null) {
                HtmlNode FPSLink = secondCell.SelectSingleNode("a");
                if(FPSLink != null) {
                    FPS = FPSLink.InnerText;
                }
            }

            // Finally, third cell holds number of discs for the movie
            HtmlNode thirdCell = cells.ElementAt(2);
            if(thirdCell != null) {
                numberOfDiscs = Convert.ToInt32(thirdCell.InnerText);
            }

            Subtitle sub = new Subtitle(title, version, downloadURL, FPS, numberOfDiscs);
            return sub;
        }

        //increments total paresed subtitles count and sets status bar in main form
        private void setProgress() {
            parsedSubs++;
            int total = (pageCount) * subsPerPage;
            double progress = ((double)parsedSubs / (double)total) * 100;
            mainForm.setProgress((int)progress);
        }
        
        //searches for number of result pages
        private int getPageNumbers(HtmlAgilityPack.HtmlDocument document) {
            //gets <button> tag with "selector" class
            //it holds the information how many result pages there is
            try {
                HtmlNode bodyNode = document.DocumentNode.SelectSingleNode("//body");
                if (bodyNode != null) {
                    HtmlNode paginationList = document.DocumentNode.SelectSingleNode("//ul[@class='pagination']");
                    if (paginationList != null) {
                        HtmlNode[] listItems = paginationList.SelectNodes(".//li").ToArray();
                        HtmlNode lastPage = listItems[listItems.Length - 2];
                        String pagesString = lastPage.InnerText;
                        Console.Write("STRANICA: " + pagesString);
                        return Convert.ToInt32(pagesString);
                    }else
                    return 0;
                } else {
                    return 0;
                }
            } catch {
                return 0;
            }
        }
    }//CLASS END
}//NAMESPACE END