namespace Titlalica_3 {
    partial class TitlalicaTabPage {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.subtitlesTable = new System.Windows.Forms.DataGridView();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.subtitlesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // subtitlesTable
            // 
            this.subtitlesTable.AllowUserToAddRows = false;
            this.subtitlesTable.AllowUserToDeleteRows = false;
            this.subtitlesTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subtitlesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.subtitlesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subtitlesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.Title,
            this.Version,
            this.CDs,
            this.FPS});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.subtitlesTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.subtitlesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtitlesTable.Location = new System.Drawing.Point(0, 0);
            this.subtitlesTable.Name = "subtitlesTable";
            this.subtitlesTable.ReadOnly = true;
            this.subtitlesTable.RowHeadersVisible = false;
            this.subtitlesTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.subtitlesTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.subtitlesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subtitlesTable.Size = new System.Drawing.Size(733, 292);
            this.subtitlesTable.TabIndex = 0;
            // 
            // Nr
            // 
            this.Nr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            this.Nr.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nr.HeaderText = "#";
            this.Nr.Name = "Nr";
            this.Nr.ReadOnly = true;
            this.Nr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nr.Width = 30;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Title.ToolTipText = "Movie title";
            this.Title.Width = 280;
            // 
            // Version
            // 
            this.Version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            this.Version.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Version.Width = 300;
            // 
            // CDs
            // 
            this.CDs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CDs.DefaultCellStyle = dataGridViewCellStyle3;
            this.CDs.HeaderText = "#CD";
            this.CDs.Name = "CDs";
            this.CDs.ReadOnly = true;
            this.CDs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CDs.Width = 35;
            // 
            // FPS
            // 
            this.FPS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FPS.DefaultCellStyle = dataGridViewCellStyle4;
            this.FPS.HeaderText = "FPS";
            this.FPS.Name = "FPS";
            this.FPS.ReadOnly = true;
            this.FPS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FPS.Width = 70;
            // 
            // TitlalicaTabPage
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.subtitlesTable);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "TitlalicaTabPage";
            this.Size = new System.Drawing.Size(733, 292);
            ((System.ComponentModel.ISupportInitialize)(this.subtitlesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView subtitlesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn FPS;
    }
}
