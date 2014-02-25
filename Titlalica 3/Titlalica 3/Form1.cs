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

namespace Titlalica_3 {
    public partial class MainForm : Form {
        
        //SETTINGS:
        //SEARCH IN NEW TAB - if true every serarched title is shown in its own tab page
        private bool searchInNewTab;

        public MainForm() {
            InitializeComponent();
            setUp();
            languageCB.SelectedIndex = 0;
            progressBar.Visible = false;
            this.ActiveControl = searchTF;
            mainMenu.ForeColor = Color.White;
            for (int i = 0; i < 50; i++) {
                defaultTable.Rows.Add(i+1, "Batman The Dark Knight", "Batman.The.Dark.Knight.PROPPER.aXXo.740p", "1", "24");
                defaultTable.Rows.Add(i+2, "Batman The Dark Knight", "Batman.The.Dark.Knight.BRRip.Division.MultiSubs.14520p", "1", "N/A");
            }
        }

        private void setUp() {
            String searchInNewTabSetting = System.Configuration.ConfigurationManager.AppSettings["searchInNewTab"].ToString();
            this.searchInNewTab = Convert.ToBoolean(searchInNewTabSetting);
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
            if (!title.Equals("")) {
                if (searchInNewTab) {
                    if (tabPanel.TabPages[0].Text.Equals("Search 1")) {
                        tabPanel.TabPages[0].Text = title;
                    }
                    else {
                        TabPage newTab = new TabPage();
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

        public void setSearchInNewTab(Boolean value) {
            this.searchInNewTab = value;
            if (!value) {
                clearTabs();
            }
            updateSettings();
        }

        //saves application settings to config file
        private void updateSettings() {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["searchInNewTab"].Value = this.searchInNewTab.ToString();

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

        public Boolean getSearchInNewTab() {
            return this.searchInNewTab;
        }

    }//CLASS END
}//NAMESPACE END
