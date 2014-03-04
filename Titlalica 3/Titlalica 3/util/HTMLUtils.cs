using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Titlalica_3.util {
    
    /*
     * Contains common HTML parsing methods
     */
    public class HTMLUtils {

        MainForm mainForm;

        public HTMLUtils(MainForm mf) {
            this.mainForm = mf;
        }

        //connects to specified URL and returns HTMLDocument object
        public HtmlAgilityPack.HtmlDocument getDocument(String url) {
            HtmlAgilityPack.HtmlDocument doc = null;

            //set up web client that connects to web page
            WebClient client = new WebClient();
            if (mainForm.getUseProxy()) {
                WebProxy proxy = new WebProxy("http://" + mainForm.getProxyAddress() + ":" + mainForm.getProxyPort());
                client.Proxy = proxy;
            }

            //open connection to website
            try {
                Stream response = client.OpenRead(url);
                doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(response);
                response.Close();
            } catch {
                return null;
            }
            return doc;
        }

        public String getAttributeValue(HtmlNode node, String attributeName) {
            HtmlAttributeCollection attributes = node.Attributes;
            foreach (HtmlAttribute attribute in attributes) {
                if (attribute.Name.Equals(attributeName)) {
                    return attribute.Value;
                }
            }
            return null; ;
        }

    }
}
