using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Titlalica_3.crawlers {
    /*
     * Class used to crawl site podnapisi.net and provide list of search results
     * podnapisi.net is used to search only for english subtitles
     * */
    class PodnapisiCrawler {

        MainForm mainForm;
        String title;

        public PodnapisiCrawler(MainForm caller, String movie) {
            this.mainForm = caller;
            this.title = movie;
        }

        public void search() {
            WebClient myClient = new WebClient();
            String searchURL = "http://www.podnapisi.net/en/ppodnapisi/search/sJ/2/sS//sO//sT/-1/sM/0/sA/0/sK/" + 
                                title.Replace(" ", "+")  + 
                                "/sOA/0/sOT/0/sOL/0/sOI/0/sOE/0/sOD/0/sOH/0/sY//sOCS/0/sFT/0/sR//sTS//sTE//sAKA/1/sH//sI//tbsl/1/asdp/0/page//page/1";
            //open connection to website
            Stream response = myClient.OpenRead(searchURL);
            int pages = getPageNumbers(response);            
            response.Close();
            mainForm.resetCursor();
            mainForm.setStatus("Found " + pages + " pages of subtitles.");
        }

        //searches for number of result pages
        private int getPageNumbers(Stream html) {
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.Load(html);

            //gets <button> tag with "selector" class
            //it holds the information how many result pages there is
            HtmlNode bodyNode = document.DocumentNode.SelectSingleNode("//body");
            if (bodyNode != null) {
                HtmlNodeCollection buttons = bodyNode.SelectNodes("//button");
                foreach(HtmlNode button in buttons) {
                    HtmlAttributeCollection attributes = button.Attributes;
                    foreach (HtmlAttribute attribute in attributes) {
                        if (attribute.Name.Equals("class") && attribute.Value.Equals("selector")) {
                            //get only first part of text discarding 'pages' part
                            String pagesString = button.InnerText.Split(' ')[0];
                            return Convert.ToInt32(pagesString);
                        }
                    }
                }
            }
            return 0;
        }

    }//CLASS END
}//NAMESPACE END