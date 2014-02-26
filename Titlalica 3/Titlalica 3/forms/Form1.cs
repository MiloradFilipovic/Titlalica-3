using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Titlalica_3.crawlers;
using System.Threading;

namespace Titlalica_3 {
    public partial class MainForm : Form {
        
        //SETTINGS:
        //SEARCH IN NEW TAB - if true every serarched title is shown in its own tab page
        private bool searchInNewTab;
        //PROXY SETTINGS:
        private bool useProxy;
        private String proxyAddress;
        private String proxyPort;


        //delegates that update UI controls from search threads
        delegate void ResetCursorCallback();
        delegate void SetTextCallBack(String text);

        public MainForm() {
            InitializeComponent();
            init();
            setUp();
        }

        private void init() {
            languageCB.SelectedIndex = 0;
            progressBar.Visible = false;
            statusLabel.Text = "";
            this.ActiveControl = searchTF;
            mainMenu.ForeColor = Color.White;
            DataGridView table = (DataGridView)titlalicaTabPage1.Controls[0];
            /*for (int i = 0; i < 50; i++) {
                table.Rows.Add(i+1, "Batman The Dark Knight", "Batman.The.Dark.Knight.PROPPER.aXXo.740p", "1", "24");
                table.Rows.Add(i+2, "Batman The Dark Knight", "Batman.The.Dark.Knight.BRRip.Division.MultiSubs.14520p", "1", "N/A");
            }*/
        }

        //READ CONFIG FILE AND SET UP UI CONTROLS
        private void setUp() {
            String searchInNewTabSetting = System.Configuration.ConfigurationManager.AppSettings["searchInNewTab"].ToString();
            String useProxyString = System.Configuration.ConfigurationManager.AppSettings["useProxy"].ToString();
            String proxyAddress = System.Configuration.ConfigurationManager.AppSettings["proxyAddress"].ToString();
            String proxyPort = System.Configuration.ConfigurationManager.AppSettings["proxyPort"].ToString();
            String opacityString = System.Configuration.ConfigurationManager.AppSettings["opacity"].ToString();
            this.searchInNewTab = Convert.ToBoolean(searchInNewTabSetting);
            this.useProxy = Convert.ToBoolean(useProxyString);
            this.proxyAddress = proxyAddress;
            this.proxyPort = proxyPort;
            this.Opacity = Convert.ToDouble(opacityString);
        }

        //CLICK ON SEARCH BUTTON
        private void searchButton_Click(object sender, EventArgs e) {
            search();
        }

        //ENTER KEY PRESSED IN TEXT BOX
        private void searchTF_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                search();
            }
        }

        public void search() {
            String title = searchTF.Text;
            String language = languageCB.SelectedItem.ToString();
            setStatus("Searching, please wait....");
            this.Cursor = Cursors.WaitCursor;
            if (language.Equals("English")) {
                PodnapisiCrawler podnapisiCrawler = new PodnapisiCrawler(this, title);
                Thread thread = new Thread(new ThreadStart(podnapisiCrawler.search));
                thread.Start();
            }

            if (!title.Equals("")) {
                if (searchInNewTab) {
                    if (tabPanel.TabPages[0].Text.Equals("Search 1")) {
                        tabPanel.TabPages[0].Text = title;
                    }
                    else {
                        TabPage newTab = new TabPage();
                        TitlalicaTabPage tit = new TitlalicaTabPage();
                        newTab.Controls.Add(tit);
                        newTab.Text = title;
                        tabPanel.TabPages.Add(newTab);
                        tabPanel.SelectedTab = newTab;
                    }
                }else {
                    tabPanel.TabPages[0].Text = title;
                }
                this.ActiveControl = searchTF;
                searchTF.SelectAll();
            }
        }

        //saves application settings to config file
        public void updateSettings() {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["searchInNewTab"].Value = this.searchInNewTab.ToString();
            config.AppSettings.Settings["useProxy"].Value = this.useProxy.ToString();
            config.AppSettings.Settings["proxyAddress"].Value = this.proxyAddress;
            config.AppSettings.Settings["proxyPort"].Value = this.proxyPort;
            config.AppSettings.Settings["opacity"].Value = this.Opacity.ToString();

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        //clears tabs, leaves only one tab page
        public void clearTabs() {
            TabPage defaultPage = tabPanel.TabPages[0];
            defaultPage.Text = "Search 1";
            tabPanel.TabPages.Clear();
            tabPanel.TabPages.Add(defaultPage);
        }

        //----------------------------------------------------------------LISTENER METHODS
        private void clearSearchBtn_Click(object sender, EventArgs e) {
            clearTabs();
            searchTF.Text = "";
            this.ActiveControl = searchTF;
        }

        private void settingsBtn_Click(object sender, EventArgs e) {
            SettingsForm settings = new SettingsForm(this);
            settings.ShowDialog(this);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
            SettingsForm settings = new SettingsForm(this);
            settings.ShowDialog(this);
        }

        //--------------------------------------------------------------SET AND GET METHODS
        public Boolean getSearchInNewTab() {
            return this.searchInNewTab;
        }

        public void setSearchInNewTab(Boolean value) {
            this.searchInNewTab = value;
            if (!value) {
                clearTabs();
            }
        }

        public Boolean getUseProxy() {
            return this.useProxy;
        }

        public void setUseProxy(Boolean use) {
            this.useProxy = use;
        }

        public String getProxyAddress() {
            return this.proxyAddress;
        }

        public String getProxyPort() {
            return this.proxyPort;
        }

        public void setProxy(String address, String port) {
            this.proxyAddress = address;
            this.proxyPort = port;
        }

        public void setStatus(String text) {
            if (this.InvokeRequired) {
                SetTextCallBack d = new SetTextCallBack(setStatus);
                this.Invoke(d, new object[] {text});
            } else {
                statusLabel.Text = text;
            }
        }

        public void resetCursor() {
            //makes sure method is invoked in same thread as this form
            if (this.InvokeRequired) {
                ResetCursorCallback d = new ResetCursorCallback(resetCursor);
                this.Invoke(d);
            } else {
                this.Cursor = Cursors.Default;
            }
        }

    }//CLASS END
}//NAMESPACE END