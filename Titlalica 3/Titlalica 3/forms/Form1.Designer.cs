using System.Windows.Forms;
namespace Titlalica_3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.clearSearchBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.languageCB = new System.Windows.Forms.ComboBox();
            this.searchTF = new System.Windows.Forms.TextBox();
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.defaultPage = new System.Windows.Forms.TabPage();
            this.titlalicaTabPage1 = new Titlalica_3.TitlalicaTabPage();
            this.layotPanel = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.defaultPage.SuspendLayout();
            this.layotPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.layotPanel.SetColumnSpan(this.mainMenu, 3);
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.searchToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(562, 3);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainMenu.Size = new System.Drawing.Size(205, 23);
            this.mainMenu.TabIndex = 9;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadSelectedToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(44, 19);
            this.fileToolStripMenuItem1.Text = "Help";
            // 
            // downloadSelectedToolStripMenuItem
            // 
            this.downloadSelectedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.downloadSelectedToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.downloadSelectedToolStripMenuItem.Name = "downloadSelectedToolStripMenuItem";
            this.downloadSelectedToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.downloadSelectedToolStripMenuItem.Text = "Help";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.settingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.settingToolStripMenuItem.Text = "About";
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSearchToolStripMenuItem});
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(57, 19);
            this.searchToolStripMenuItem1.Text = "Search";
            // 
            // newSearchToolStripMenuItem
            // 
            this.newSearchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.newSearchToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newSearchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.newSearchToolStripMenuItem.Name = "newSearchToolStripMenuItem";
            this.newSearchToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newSearchToolStripMenuItem.Text = "New search";
            this.newSearchToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newSearchToolStripMenuItem.ToolTipText = "Clears search text and closes all tabs";
            this.newSearchToolStripMenuItem.Click += new System.EventHandler(this.newSearchToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadSelectedToolStripMenuItem1,
            this.openFilesToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.helpToolStripMenuItem.Text = "File";
            // 
            // downloadSelectedToolStripMenuItem1
            // 
            this.downloadSelectedToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.downloadSelectedToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.downloadSelectedToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Menu;
            this.downloadSelectedToolStripMenuItem1.Name = "downloadSelectedToolStripMenuItem1";
            this.downloadSelectedToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.downloadSelectedToolStripMenuItem1.Text = "Download selected";
            this.downloadSelectedToolStripMenuItem1.Click += new System.EventHandler(this.downloadSelectedToolStripMenuItem1_Click);
            // 
            // openFilesToolStripMenuItem
            // 
            this.openFilesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.openFilesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.openFilesToolStripMenuItem.Name = "openFilesToolStripMenuItem";
            this.openFilesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.openFilesToolStripMenuItem.Text = "...Open files";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.settingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Menu;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.settingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsBtn.BackgroundImage")));
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Location = new System.Drawing.Point(722, 70);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(42, 33);
            this.settingsBtn.TabIndex = 8;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // clearSearchBtn
            // 
            this.clearSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.clearSearchBtn.BackgroundImage = global::Titlalica_3.Properties.Resources.clear;
            this.clearSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearSearchBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.clearSearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.clearSearchBtn.Location = new System.Drawing.Point(718, 29);
            this.clearSearchBtn.Name = "clearSearchBtn";
            this.clearSearchBtn.Size = new System.Drawing.Size(41, 35);
            this.clearSearchBtn.TabIndex = 7;
            this.clearSearchBtn.UseVisualStyleBackColor = false;
            this.clearSearchBtn.Click += new System.EventHandler(this.clearSearchBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(234)))), ((int)(((byte)(150)))));
            this.progressBar.Location = new System.Drawing.Point(389, 439);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.progressBar.MaximumSize = new System.Drawing.Size(170, 15);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(170, 15);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.statusLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.statusLabel.Location = new System.Drawing.Point(23, 439);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(223, 16);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Subtitle downloaded to C:\\\\Users\\mrd\\Desktop";
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.downloadButton.BackgroundImage = global::Titlalica_3.Properties.Resources.download;
            this.downloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.layotPanel.SetColumnSpan(this.downloadButton, 2);
            this.downloadButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.downloadButton.Location = new System.Drawing.Point(710, 437);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(54, 20);
            this.downloadButton.TabIndex = 4;
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.searchButton.BackgroundImage = global::Titlalica_3.Properties.Resources.search;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchButton.Location = new System.Drawing.Point(669, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(43, 35);
            this.searchButton.TabIndex = 3;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // languageCB
            // 
            this.languageCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.languageCB.Dock = System.Windows.Forms.DockStyle.Left;
            this.languageCB.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageCB.ForeColor = System.Drawing.SystemColors.Control;
            this.languageCB.FormattingEnabled = true;
            this.languageCB.Items.AddRange(new object[] {
            "English",
            "Serbian",
            "Croatian"});
            this.languageCB.Location = new System.Drawing.Point(565, 29);
            this.languageCB.MaxDropDownItems = 3;
            this.languageCB.Name = "languageCB";
            this.languageCB.Size = new System.Drawing.Size(94, 32);
            this.languageCB.TabIndex = 2;
            // 
            // searchTF
            // 
            this.searchTF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.layotPanel.SetColumnSpan(this.searchTF, 2);
            this.searchTF.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchTF.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTF.ForeColor = System.Drawing.SystemColors.Control;
            this.searchTF.Location = new System.Drawing.Point(323, 29);
            this.searchTF.Name = "searchTF";
            this.searchTF.Size = new System.Drawing.Size(236, 32);
            this.searchTF.TabIndex = 1;
            this.searchTF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTF_KeyDown);
            // 
            // tabPanel
            // 
            this.layotPanel.SetColumnSpan(this.tabPanel, 5);
            this.tabPanel.Controls.Add(this.defaultPage);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPanel.Location = new System.Drawing.Point(23, 109);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(741, 322);
            this.tabPanel.TabIndex = 0;
            this.tabPanel.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPanel_Selected);
            // 
            // defaultPage
            // 
            this.defaultPage.AutoScroll = true;
            this.defaultPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.defaultPage.Controls.Add(this.titlalicaTabPage1);
            this.defaultPage.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(234)))), ((int)(((byte)(150)))));
            this.defaultPage.Location = new System.Drawing.Point(4, 25);
            this.defaultPage.Name = "defaultPage";
            this.defaultPage.Padding = new System.Windows.Forms.Padding(3);
            this.defaultPage.Size = new System.Drawing.Size(733, 293);
            this.defaultPage.TabIndex = 1;
            this.defaultPage.Text = "Search 1";
            // 
            // titlalicaTabPage1
            // 
            this.titlalicaTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.titlalicaTabPage1.ForeColor = System.Drawing.SystemColors.Control;
            this.titlalicaTabPage1.Location = new System.Drawing.Point(0, 2);
            this.titlalicaTabPage1.Name = "titlalicaTabPage1";
            this.titlalicaTabPage1.Size = new System.Drawing.Size(730, 287);
            this.titlalicaTabPage1.Subs = null;
            this.titlalicaTabPage1.TabIndex = 0;
            // 
            // layotPanel
            // 
            this.layotPanel.BackgroundImage = global::Titlalica_3.Properties.Resources.background1;
            this.layotPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layotPanel.CausesValidation = false;
            this.layotPanel.ColumnCount = 5;
            this.layotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.03856F));
            this.layotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.77024F));
            this.layotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.19121F));
            this.layotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.layotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layotPanel.Controls.Add(this.tabPanel, 0, 4);
            this.layotPanel.Controls.Add(this.searchTF, 0, 2);
            this.layotPanel.Controls.Add(this.languageCB, 2, 2);
            this.layotPanel.Controls.Add(this.searchButton, 3, 2);
            this.layotPanel.Controls.Add(this.downloadButton, 3, 5);
            this.layotPanel.Controls.Add(this.statusLabel, 0, 5);
            this.layotPanel.Controls.Add(this.progressBar, 1, 5);
            this.layotPanel.Controls.Add(this.clearSearchBtn, 4, 2);
            this.layotPanel.Controls.Add(this.settingsBtn, 4, 3);
            this.layotPanel.Controls.Add(this.mainMenu, 2, 1);
            this.layotPanel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layotPanel.Location = new System.Drawing.Point(0, -1);
            this.layotPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.layotPanel.Name = "layotPanel";
            this.layotPanel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 5);
            this.layotPanel.RowCount = 6;
            this.layotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.84615F));
            this.layotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.15385F));
            this.layotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.layotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.layotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 328F));
            this.layotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layotPanel.Size = new System.Drawing.Size(787, 465);
            this.layotPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.layotPanel);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titlalica 3";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contextMenuStrip1.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tabPanel.ResumeLayout(false);
            this.defaultPage.ResumeLayout(false);
            this.layotPanel.ResumeLayout(false);
            this.layotPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private FolderBrowserDialog folderBrowserDialog;
        private MenuStrip mainMenu;
        private TableLayoutPanel layotPanel;
        private TabControl tabPanel;
        private TabPage defaultPage;
        private TitlalicaTabPage titlalicaTabPage1;
        private TextBox searchTF;
        private ComboBox languageCB;
        private Button searchButton;
        private Button downloadButton;
        private Label statusLabel;
        private ProgressBar progressBar;
        private Button clearSearchBtn;
        private Button settingsBtn;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem downloadSelectedToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem1;
        private ToolStripMenuItem newSearchToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem downloadSelectedToolStripMenuItem1;
        private ToolStripMenuItem openFilesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}