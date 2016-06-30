using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;
using System.Drawing;
using System.Net;
using System.ComponentModel;

namespace Titlalica_3.util {

    class SubtitleDownloader {

        static MainForm mainForm;
        HTMLUtils HTMLUtils;

        public SubtitleDownloader(MainForm mf) {
            mainForm = mf;
            this.HTMLUtils = new HTMLUtils(mf);
        }

        public void downloadTitloviFile(string url, string folderPath, string fileName) {
            Uri downURL = new Uri(url);
            HtmlDocument doc = HTMLUtils.getDocument(url);
            if (doc != null) {
                HtmlNode bodyNode = doc.DocumentNode.SelectSingleNode("//body");
                if (bodyNode != null) {
                    // Download link is in the link button with the css class 'button s1 button-download'
                    HtmlNode downloadButton = bodyNode.SelectSingleNode("//a[@class='button s1 button-download']");
                    string downloadLink = HTMLUtils.getAttributeValue(downloadButton, "href");
                    WebClient client = new WebClient();
                    try {
                        Console.WriteLine("DOWNLOADING: " + downloadLink);
                        Console.WriteLine("TO: " + folderPath + "//" + fileName);
                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
                        client.DownloadFileAsync(new Uri(downloadLink), folderPath + "\\" + fileName);
                    }
                    catch {
                        mainForm.countDownload(true);
                    }
                }
            }else {
                mainForm.countDownload(true);
            }
        }

        public void downloadPodnapisiFile(String url, String folderPath, String fileName) {
            string downloadPage = "http://www.podnapisi.net" + url;
            Uri downURL = new Uri(downloadPage);
            WebClient client = new WebClient();
            try {
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
                client.DownloadFileAsync(downURL, folderPath + "\\" + fileName);
            }catch {
                mainForm.countDownload(true);
            }
        }
        static void DownloadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
            mainForm.countDownload(false);
        }
    }
}
