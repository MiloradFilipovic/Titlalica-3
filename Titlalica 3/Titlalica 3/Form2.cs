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

    public partial class SettingsForm : Form {

        MainForm mainForm;

        public SettingsForm() {
            InitializeComponent();
        }

        public SettingsForm(MainForm caller) {
            this.mainForm = caller;
            InitializeComponent();
            init();
        }

        private void init() {
            searchInNewTabCB.Checked = mainForm.searchInNewTab;
        }

        private void okBtn_Click(object sender, EventArgs e) {
            this.mainForm.searchInNewTab = searchInNewTabCB.Checked;
            this.Dispose();
            this.Visible = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Dispose();
            this.Visible = false;
        }
    }
}
