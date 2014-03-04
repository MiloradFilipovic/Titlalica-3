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
            searchInNewTabCB.Checked = mainForm.getSearchInNewTab();
            proxyCB.Checked = mainForm.getUseProxy();
            systemSettingsCB.Checked = !mainForm.getUseProxy();
            proxyTF.Text = mainForm.getProxyAddress();
            portTF.Text = mainForm.getProxyPort();
            setTextBoxes(mainForm.getUseProxy());
            opacitySlider.Value = (int)(this.mainForm.Opacity * 100);
        }

        private void okBtn_Click(object sender, EventArgs e) {
            this.mainForm.setSearchInNewTab(searchInNewTabCB.Checked);
            this.mainForm.setUseProxy(proxyCB.Checked);
            this.mainForm.setProxy(proxyTF.Text.Trim(), portTF.Text.Trim());
            this.mainForm.updateSettings();
            this.Dispose();
            this.Visible = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Dispose();
            this.Visible = false;
        }

        private void proxyCB_CheckedChanged(object sender, EventArgs e) {
            setTextBoxes(proxyCB.Checked);
            systemSettingsCB.Checked = !proxyCB.Checked;
        }

        private void systemSettingsCB_CheckedChanged(object sender, EventArgs e) {
            proxyCB.Checked = !systemSettingsCB.Checked;
            //if 'Use system settings' is checked, no proxy is used
            mainForm.setUseProxy(!systemSettingsCB.Checked);
        }

        private void setTextBoxes(Boolean enabled) {
            if (enabled) {
                proxyTF.Enabled = true;
                portTF.Enabled = true;
            } else {
                proxyTF.Enabled = false;
                portTF.Enabled = false;
            }
        }

        private void opacitySlider_Scroll(object sender, EventArgs e) {
            this.mainForm.Opacity = (double)opacitySlider.Value / 100;
        }
    }
}