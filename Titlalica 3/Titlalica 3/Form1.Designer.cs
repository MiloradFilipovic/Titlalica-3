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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.layotPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.defaultPage = new System.Windows.Forms.TabPage();
            this.defaultTable = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTF = new System.Windows.Forms.TextBox();
            this.languageCB = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.clearSearchBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layotPanel.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.defaultPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultTable)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layotPanel
            // 
            this.layotPanel.BackgroundImage = global::Titlalica_3.Properties.Resources.background;
            this.layotPanel.ColumnCount = 5;
            this.layotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.03856F));
            this.layotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.77024F));
            this.layotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.19121F));
            this.layotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layotPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.layotPanel.Controls.Add(this.tabPanel, 0, 4);
            this.layotPanel.Controls.Add(this.searchTF, 0, 2);
            this.layotPanel.Controls.Add(this.languageCB, 2, 2);
            this.layotPanel.Controls.Add(this.searchButton, 3, 2);
            this.layotPanel.Controls.Add(this.downloadButton, 3, 5);
            this.layotPanel.Controls.Add(this.label1, 0, 5);
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
            this.layotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 327F));
            this.layotPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.layotPanel.Size = new System.Drawing.Size(787, 465);
            this.layotPanel.TabIndex = 0;
            // 
            // tabPanel
            // 
            this.layotPanel.SetColumnSpan(this.tabPanel, 5);
            this.tabPanel.Controls.Add(this.defaultPage);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.Location = new System.Drawing.Point(23, 110);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(741, 321);
            this.tabPanel.TabIndex = 0;
            // 
            // defaultPage
            // 
            this.defaultPage.AutoScroll = true;
            this.defaultPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.defaultPage.Controls.Add(this.defaultTable);
            this.defaultPage.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(234)))), ((int)(((byte)(150)))));
            this.defaultPage.Location = new System.Drawing.Point(4, 25);
            this.defaultPage.Name = "defaultPage";
            this.defaultPage.Padding = new System.Windows.Forms.Padding(3);
            this.defaultPage.Size = new System.Drawing.Size(733, 292);
            this.defaultPage.TabIndex = 1;
            this.defaultPage.Text = "Search 1";
            // 
            // defaultTable
            // 
            this.defaultTable.AllowUserToAddRows = false;
            this.defaultTable.AllowUserToDeleteRows = false;
            this.defaultTable.AllowUserToResizeColumns = false;
            this.defaultTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.defaultTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.defaultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.title,
            this.version,
            this.CDs,
            this.fps});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(234)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.defaultTable.DefaultCellStyle = dataGridViewCellStyle31;
            this.defaultTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultTable.Location = new System.Drawing.Point(3, 3);
            this.defaultTable.Name = "defaultTable";
            this.defaultTable.ReadOnly = true;
            this.defaultTable.RowHeadersVisible = false;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultTable.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.defaultTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.defaultTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.defaultTable.Size = new System.Drawing.Size(727, 286);
            this.defaultTable.TabIndex = 0;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.DefaultCellStyle = dataGridViewCellStyle26;
            this.number.Frozen = true;
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.number.Width = 38;
            // 
            // title
            // 
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.DefaultCellStyle = dataGridViewCellStyle27;
            this.title.Frozen = true;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 250;
            // 
            // version
            // 
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.DefaultCellStyle = dataGridViewCellStyle28;
            this.version.Frozen = true;
            this.version.HeaderText = "Version";
            this.version.Name = "version";
            this.version.ReadOnly = true;
            this.version.Width = 335;
            // 
            // CDs
            // 
            this.CDs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDs.DefaultCellStyle = dataGridViewCellStyle29;
            this.CDs.Frozen = true;
            this.CDs.HeaderText = "CD#";
            this.CDs.Name = "CDs";
            this.CDs.ReadOnly = true;
            this.CDs.Width = 40;
            // 
            // fps
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fps.DefaultCellStyle = dataGridViewCellStyle30;
            this.fps.Frozen = true;
            this.fps.HeaderText = "FPS";
            this.fps.Name = "fps";
            this.fps.ReadOnly = true;
            this.fps.Width = 55;
            // 
            // searchTF
            // 
            this.searchTF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.layotPanel.SetColumnSpan(this.searchTF, 2);
            this.searchTF.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchTF.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(234)))), ((int)(((byte)(150)))));
            this.searchTF.Location = new System.Drawing.Point(309, 29);
            this.searchTF.Name = "searchTF";
            this.searchTF.Size = new System.Drawing.Size(236, 32);
            this.searchTF.TabIndex = 1;
            this.searchTF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTF_KeyDown);
            // 
            // languageCB
            // 
            this.languageCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.languageCB.Dock = System.Windows.Forms.DockStyle.Left;
            this.languageCB.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(234)))), ((int)(((byte)(150)))));
            this.languageCB.FormattingEnabled = true;
            this.languageCB.Items.AddRange(new object[] {
            "English",
            "Serbian",
            "Croatian"});
            this.languageCB.Location = new System.Drawing.Point(551, 29);
            this.languageCB.MaxDropDownItems = 3;
            this.languageCB.Name = "languageCB";
            this.languageCB.Size = new System.Drawing.Size(96, 32);
            this.languageCB.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.searchButton.BackgroundImage = global::Titlalica_3.Properties.Resources.search;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchButton.Location = new System.Drawing.Point(653, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(44, 35);
            this.searchButton.TabIndex = 3;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(234)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(23, 439);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subtitle downloaded to C:\\\\Users\\mrd\\Desktop";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(234)))), ((int)(((byte)(150)))));
            this.progressBar.Location = new System.Drawing.Point(371, 437);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(174, 20);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            // 
            // clearSearchBtn
            // 
            this.clearSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.clearSearchBtn.BackgroundImage = global::Titlalica_3.Properties.Resources.clear;
            this.clearSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearSearchBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.clearSearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.clearSearchBtn.Location = new System.Drawing.Point(703, 29);
            this.clearSearchBtn.Name = "clearSearchBtn";
            this.clearSearchBtn.Size = new System.Drawing.Size(46, 35);
            this.clearSearchBtn.TabIndex = 7;
            this.clearSearchBtn.UseVisualStyleBackColor = false;
            this.clearSearchBtn.Click += new System.EventHandler(this.clearSearchBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.settingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsBtn.BackgroundImage")));
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Location = new System.Drawing.Point(703, 70);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(42, 34);
            this.settingsBtn.TabIndex = 8;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
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
            this.mainMenu.Location = new System.Drawing.Point(548, 3);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainMenu.Size = new System.Drawing.Size(219, 23);
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
            this.downloadSelectedToolStripMenuItem.Name = "downloadSelectedToolStripMenuItem";
            this.downloadSelectedToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.downloadSelectedToolStripMenuItem.Text = "Help";
            // 
            // settingToolStripMenuItem
            // 
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
            this.newSearchToolStripMenuItem.Name = "newSearchToolStripMenuItem";
            this.newSearchToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newSearchToolStripMenuItem.Text = "New search";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadSelectedToolStripMenuItem1,
            this.settingsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.helpToolStripMenuItem.Text = "File";
            // 
            // downloadSelectedToolStripMenuItem1
            // 
            this.downloadSelectedToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.downloadSelectedToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Menu;
            this.downloadSelectedToolStripMenuItem1.Name = "downloadSelectedToolStripMenuItem1";
            this.downloadSelectedToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.downloadSelectedToolStripMenuItem1.Text = "Download selected";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Menu;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Titlalica_3.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.layotPanel);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titlalica 3";
            this.layotPanel.ResumeLayout(false);
            this.layotPanel.PerformLayout();
            this.tabPanel.ResumeLayout(false);
            this.defaultPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.defaultTable)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layotPanel;
        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage defaultPage;
        private System.Windows.Forms.TextBox searchTF;
        private System.Windows.Forms.ComboBox languageCB;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridView defaultTable;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearSearchBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem downloadSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadSelectedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn version;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn fps;
    }
}

