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

        public PodnapisiCrawler(MainForm caller, String movie) {
            HTMLUtils = new HTMLUtils(caller);
            this.mainForm = caller;
            this.title = movie;
            this.searchURL = "http://www.podnapisi.net/en/ppodnapisi/search/sJ/2/sS//sO//sT/-1/sM/0/sA/0/sK/" + 
                              title.Replace(" ", "+")  + 
                              "/sOA/0/sOT/0/sOL/0/sOI/0/sOE/0/sOD/0/sOH/0/sY//sOCS/0/sFT/0/sR//sTS//sTE//sAKA/1/sH//sI//tbsl/1/asdp/0/page//page/";
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
                //subtitles are displayed in table with class 'list first_column_title'
                HtmlNode bodyNode = document.DocumentNode.SelectSingleNode("//body");
                if (bodyNode != null) {
                    HtmlNodeCollection rows = bodyNode.SelectNodes("//table[@class='list first_column_title']/tbody/tr");
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
            Subtitle sub = null;
            
            //get all row cells
            HtmlNodeCollection cells = row.SelectNodes("td");
            
            //first cell contains two <div> elemens, first is skipped
            //second contains <div> with class 'list_div2' with usefull info
            HtmlNode firstCell = cells.ElementAt(0);
            HtmlNode listDiv2 = firstCell.SelectSingleNode("div[@class='list_div2']");
            if (listDiv2 != null) {
                //movie title is in <a> tag with its href containing download link
                HtmlNode movieLink = listDiv2.SelectSingleNode("a[@class='subtitle_page_link']");
                String movieTitle = movieLink.InnerText;
                String downloadURL = HTMLUtils.getAttributeValue(movieLink, "href");
                //span with class 'release' contains movie version
                HtmlNode releaseSpan = listDiv2.SelectSingleNode("span[@class='release']");
                String version = "N/A";
                if (releaseSpan != null && !releaseSpan.InnerText.Trim().Equals("")) {
                    version = releaseSpan.InnerText.Trim();
                }

                //second cell contains FPS
                HtmlNode secondCell = cells.ElementAt(1);
                String fps = "N/A";
                if (secondCell.InnerText != null) {
                    fps = secondCell.InnerText;
                }
                //number of discs is in fifth cell
                HtmlNode fifthCell = cells.ElementAt(4);
                int numberOfDiscs = Convert.ToInt32(fifthCell.InnerText);

                sub = new Subtitle(movieTitle, version, downloadURL, fps, numberOfDiscs);
            }
            return sub;
        }

        //increments total paresed subtitles count and sets status bar in main form
        private void setProgress() {
            parsedSubs++;
            int total = (pageCount) * 30;
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
                    HtmlNode button = bodyNode.SelectSingleNode("//button[@class='selector']");
                    if (button != null) {
                        String pagesString = button.InnerText.Split(' ')[0];
                        return Convert.ToInt32(pagesString);
                    }
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