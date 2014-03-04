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

    class PodnapisiDownloader {

        static MainForm mainForm;
        HTMLUtils HTMLUtils;

        public PodnapisiDownloader(MainForm mf) {
            mainForm = mf;
            this.HTMLUtils = new HTMLUtils(mf);
        }

        public void download(String url, String folderPath, String fileName) {
            String downloadPage = "http://www.podnapisi.net" + url;
            Uri downURL = new Uri(downloadPage);
            HtmlDocument doc = HTMLUtils.getDocument(downloadPage);
            if (doc != null) {
                HtmlNode bodyNode = doc.DocumentNode.SelectSingleNode("//body");
                if (bodyNode != null) {
                    //download button is <a> which href attribute points to actual subtitle link
                    HtmlNode downloadButton = bodyNode.SelectSingleNode("//a[@class='button big download']");
                    String downloadLink = HTMLUtils.getAttributeValue(downloadButton, "href");
                    WebClient client = new WebClient();
                    try {
                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
                        client.DownloadFileAsync(downURL, folderPath + "\\" + fileName);
                    } catch {
                        mainForm.countDownload(true);
                    }
                }
            } else {
                mainForm.countDownload(true);
            }
        }

        static void DownloadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
            mainForm.countDownload(false);
        }

    }
}
