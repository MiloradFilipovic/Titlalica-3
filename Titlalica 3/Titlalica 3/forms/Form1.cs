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
using Titlalica_3.util;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

/**
    TITLALICA 3 MAIN WINDOW
**/
namespace Titlalica_3 {
    public partial class MainForm : Form {

        String movieTitle;
        int downloaded;
        int toDownload;
        int downloadErrors;

        //SETTINGS:
        //SEARCH IN NEW TAB - if true every serarched title is shown in its own tab page
        private bool searchInNewTab;
        //PROXY SETTINGS:
        private bool useProxy;
        private String proxyAddress;
        private String proxyPort;
        private String lastDirectory;

        //delegates that update UI controls from search threads
        delegate void ResetCursorCallback();
        delegate void SetTextCallBack(String text, Color color);
        delegate void ShowSubtitlesCallBack(List<Subtitle> subs);
        delegate void SetProgressCallBack(int value);
        delegate void DisenableCallBack(Boolean search);
        delegate void DownloadedCallBack(bool error);

        // This fixes tab flickering
        protected override CreateParams CreateParams {
            get {
                var parms = base.CreateParams;
                parms.ExStyle |= 0x02000000;
                return parms;
            }
        }

        public MainForm() {
            this.DoubleBuffered = true;
            InitializeComponent();
            init();
            setUp();
        }

        private void init() {
            languageCB.SelectedIndex = 0;
            downloaded = 0;
            downloadErrors = 0;
            progressBar.Visible = false;
            statusLabel.Text = "";
            this.ActiveControl = searchTF;
            mainMenu.ForeColor = Color.White;

            this.SetStyle(ControlStyles.DoubleBuffer, true);
        }

        //READ CONFIG FILE AND SET UP UI CONTROLS
        private void setUp() {
            String searchInNewTabSetting = System.Configuration.ConfigurationManager.AppSettings["searchInNewTab"].ToString();
            String useProxyString = System.Configuration.ConfigurationManager.AppSettings["useProxy"].ToString();
            String proxyAddress = System.Configuration.ConfigurationManager.AppSettings["proxyAddress"].ToString();
            String proxyPort = System.Configuration.ConfigurationManager.AppSettings["proxyPort"].ToString();
            String opacityString = System.Configuration.ConfigurationManager.AppSettings["opacity"].ToString();
            String lastFolderString = System.Configuration.ConfigurationManager.AppSettings["lastFolder"].ToString();
            this.searchInNewTab = Convert.ToBoolean(searchInNewTabSetting);
            this.useProxy = Convert.ToBoolean(useProxyString);
            this.proxyAddress = proxyAddress;
            this.proxyPort = proxyPort;
            this.Opacity = Convert.ToDouble(opacityString);
            this.lastDirectory = lastFolderString;
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
            if (title != "") {
                movieTitle = title;
                disenableControls(false);
                setStatus("Searching for '" + movieTitle + "',please wait....", Color.White);
                this.Cursor = Cursors.WaitCursor;
                progressBar.Value = 0;
                progressBar.Visible = true;
                if (language.Equals("English")) {
                    PodnapisiCrawler podnapisiCrawler = new PodnapisiCrawler(this, title);
                    Thread thread = new Thread(new ThreadStart(podnapisiCrawler.search));
                    thread.IsBackground = true;
                    thread.Start();
                } else {
                    String lang = "srpski";
                    if (language.Equals("Croatian")) {
                        lang = "hrvatski";
                    }
                    TitloviCrawler titloviCrawler = new TitloviCrawler(this);
                    Thread thread = new Thread(delegate() {
                        titloviCrawler.search(title, lang);
                    });
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
        }

        public void download() {
            String language = languageCB.SelectedItem.ToString();
            TabPage currentPage = tabPanel.TabPages[tabPanel.SelectedIndex];
            TitlalicaTabPage ttp = (TitlalicaTabPage)currentPage.Controls[0];
            DataGridView currentTable = (DataGridView)ttp.Controls[0];

            if (currentTable.RowCount > 0) {
                if (Directory.Exists(lastDirectory)) {
                    folderBrowserDialog.SelectedPath = lastDirectory; 
                }
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK) {
                    lastDirectory = folderBrowserDialog.SelectedPath;
                    updateSettings();
                    setStatus("Downloading...", Color.White);
                    this.Cursor = Cursors.WaitCursor;
                    progressBar.Value = 0;
                    progressBar.Visible = true;
                    disenableControls(false);
                    SubtitleDownloader downloader = new SubtitleDownloader(this);
                    string path = folderBrowserDialog.SelectedPath;
                    downloaded = 0;
                    downloadErrors = 0;
                    toDownload = currentTable.SelectedRows.Count;

                    Thread thread = new Thread(delegate() { 
                        foreach (DataGridViewRow row in currentTable.SelectedRows) {
                            //for each selected subtitle go to its download page and fetch file
                            DataGridViewCell cell = row.Cells[0];
                            int subtitleIndex = Convert.ToInt32(cell.Value);
                            Subtitle subtitle = ttp.Subs[subtitleIndex - 1];
                            string fileName = getValidFileName(subtitle.Title) + "_" + subtitleIndex.ToString() + ".zip";
                            if (language.Equals("English")) {
                                downloader.downloadPodnapisiFile(subtitle.DownloadURL, path, fileName.Replace("\n", ""));
                            }else {
                                downloader.downloadTitloviFile(subtitle.DownloadURL, path, fileName.Replace("\n", ""));
                            }
                        }
                    });
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
        }

        public void setProgress(int progress) {
            if (this.InvokeRequired) {
                SetProgressCallBack d = new SetProgressCallBack(setProgress);
                try {
                    this.Invoke(d, new object[] { progress });
                } catch {
                }
            } else {
                try {
                    progressBar.Value = progress;
                } catch {
                    Console.WriteLine("[PROGRESS EXCEPTION] " + progress.ToString());
                }
            }
        }
        public void showSubs(List<Subtitle> subs) {
            String prefix = "[EN] ";
            disenableControls(true);
            if (subs != null) {
                if (this.InvokeRequired) {
                    ShowSubtitlesCallBack d = new ShowSubtitlesCallBack(showSubs);
                    this.Invoke(d, new Object[] { subs });
                } else {
                    if (languageCB.SelectedItem.ToString().Equals("Croatian")) {
                        prefix = "[HR] ";
                    } else if (languageCB.SelectedItem.ToString().Equals("Serbian")) {
                        prefix = "[SR] ";
                    }
                    TabPage page = tabPanel.TabPages[0];
                    TitlalicaTabPage ttp = (TitlalicaTabPage)page.Controls[0];
                    DataGridView table = (DataGridView)ttp.Controls[0];
                    if (searchInNewTab) {
                        //if search in new tab option is checked, each search is shown in separate tab
                        //if first tab is empty (it is named "Search 1"), change its name and populate its table
                        if (tabPanel.TabPages[0].Text.Equals("Search 1")) {
                            tabPanel.TabPages[0].Text = prefix + movieTitle;
                            ttp.Subs = subs;
                        } else {
                            TabPage newTab = new TabPage();
                            TitlalicaTabPage tit = new TitlalicaTabPage();
                            newTab.Controls.Add(tit);
                            newTab.Text = prefix + movieTitle;
                            tabPanel.TabPages.Add(newTab);
                            tit.Subs = subs;
                            tabPanel.SelectedTab = newTab;
                            table = (DataGridView)tit.Controls[0];
                        }
                    } else {
                        //if "Search in new tab" is disabled, always show search results in first tab
                        table.Rows.Clear();
                        TabPage defaultPage = tabPanel.TabPages[0];
                        TitlalicaTabPage titPage = (TitlalicaTabPage)defaultPage.Controls[0];
                        defaultPage.Text = prefix + movieTitle;
                        titPage.Subs = subs;
                    }
                    //populate rows with subitle data
                    int i = 1;
                    foreach (Subtitle sub in subs) {
                        table.Rows.Add(i, sub.Title, sub.Version, sub.NumberOfDiscs, sub.FPS);
                        i++;
                    }
                    this.ActiveControl = searchTF;
                    searchTF.SelectAll();
                    setStatus("Found " + subs.Count + " subtitles.", Color.White);
                    progressBar.Visible = false;
                }
            } else {
                //if subtitle list is null, there was an error getting HTML document
                setStatus("Error occured! Check your internet connection.", Color.Red);
            }
            
        }

        //this method is invoked from download thread every time a file is downloaded
        //it is used to display download progress
        //if error == true, current file download failed
        public void countDownload(bool error) {
            if (this.InvokeRequired) {
                DownloadedCallBack d = new DownloadedCallBack(countDownload);
                this.Invoke(d, new object[] {error});
            } else {
                if (error) {
                    toDownload--;
                    downloadErrors++;
                    this.Cursor = Cursors.Default;
                    progressBar.Visible = false;
                    disenableControls(true);
                    setStatus("Error downloading " + downloadErrors.ToString() + " files.", Color.Red);
                } else {
                    downloaded++;
                    double progress = ((double)downloaded / toDownload) * 100;
                    setProgress((int)progress);
                    if(progress == 100) {
                        this.Cursor = Cursors.Default;
                        progressBar.Visible = false;
                        disenableControls(true);
                        setStatus(downloaded.ToString() + " subtitles successfully downloaded!", Color.White);
                    }
                }
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
            config.AppSettings.Settings["lastFolder"].Value = this.lastDirectory;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        //clears tabs, leaves only one tab page
        public void clearTabs() {
            TabPage defaultPage = tabPanel.TabPages[0];
            TitlalicaTabPage defaultTitPage = (TitlalicaTabPage)defaultPage.Controls[0];
            DataGridView defaultTable = (DataGridView)defaultTitPage.Controls[0];
            defaultTable.Rows.Clear();
            defaultPage.Text = "Search 1";
            tabPanel.TabPages.Clear();
            tabPanel.TabPages.Add(defaultPage);
            statusLabel.Text = "";
        }

        /*
        * Disables search UI controls when search begins
        * and enables them when search ends
        * Disabling and enabling is done based on search parameter
        */
        private void disenableControls(Boolean search) {
            if (this.InvokeRequired) {
                DisenableCallBack d = new DisenableCallBack(disenableControls);
                this.Invoke(d, new object[] { search });
            } else {
                searchTF.Enabled = search;
                languageCB.Enabled = search;
                searchButton.Enabled = search;
                clearSearchBtn.Enabled = search;
                helpToolStripMenuItem.Enabled = search;
                searchToolStripMenuItem1.Enabled = search;
                fileToolStripMenuItem1.Enabled = search;
                downloadButton.Enabled = search;
            }
        }

        //sets the text and color of label in status bar
        public void setStatus(String text, Color color) {
            statusLabel.ForeColor = color;
            if (this.InvokeRequired) {
                SetTextCallBack d = new SetTextCallBack(setStatus);
                this.Invoke(d, new object[] { text, color });
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

        public string getValidFileName(string originalName) {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(originalName, "");
        }

        //----------------------------------------------------------------LISTENER METHODS
        
        //when changing tabs, show corresponding count in status label
        private void tabPanel_Selected(Object sender, TabControlEventArgs e) {
            TabPage selectedTab = e.TabPage;
            try {
                TitlalicaTabPage selectedTit = (TitlalicaTabPage)selectedTab.Controls[0];
                setStatus("TOTAL: " + selectedTit.Subs.Count + " subtitles.", Color.White);
            } catch {

            }
        }

        private void clearSearchBtn_Click(object sender, EventArgs e) {
            clearTabs();
            searchTF.Text = "";
            this.ActiveControl = searchTF;
        }

        private void newSearchToolStripMenuItem_Click(object sender, EventArgs e) {
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

        private void downloadButton_Click(object sender, EventArgs e) {
            download();
        }

        private void downloadSelectedToolStripMenuItem1_Click(object sender, EventArgs e) {
            download();
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
    }//CLASS END
}//NAMESPACE END