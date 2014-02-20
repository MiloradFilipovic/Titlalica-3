using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        bool searchInNewTab = true;

        public MainForm() {
            InitializeComponent();
            languageCB.SelectedIndex = 0;
            progressBar.Visible = false;
            this.ActiveControl = searchTF;
            mainMenu.ForeColor = Color.White;
            for (int i = 0; i < 50; i++) {
                defaultTable.Rows.Add(i+1, "Batman The Dark Knight", "Batman.The.Dark.Knight.PROPPER.aXXo.740p", "1", "24");
                defaultTable.Rows.Add(i+2, "Batman The Dark Knight", "Batman.The.Dark.Knight.BRRip.Division.MultiSubs.14520p", "1", "N/A");
            }
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

        private void clearSearchBtn_Click(object sender, EventArgs e) {
            TabPage defaultPage = tabPanel.TabPages[0];
            defaultPage.Text = "Search 1";
            tabPanel.TabPages.Clear();
            tabPanel.TabPages.Add(defaultPage);
            searchTF.Text = "";
            this.ActiveControl = searchTF;
        }

    }
}
