namespace Media_Organiser
{
    partial class FileUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileUpload));
            this.menuBody = new System.Windows.Forms.Panel();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.menuHeader = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.txtDir = new System.Windows.Forms.TextBox();
            this.fileType = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.DataGridView();
            this.tblIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.tblDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFileExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBody.SuspendLayout();
            this.menuHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBody
            // 
            this.menuBody.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuBody.Controls.Add(this.btnPlaylist);
            this.menuBody.Controls.Add(this.btnReturn);
            this.menuBody.Location = new System.Drawing.Point(735, 50);
            this.menuBody.Name = "menuBody";
            this.menuBody.Size = new System.Drawing.Size(53, 100);
            this.menuBody.TabIndex = 5;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Image = global::Media_Organiser.Properties.Resources.playlist;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 52);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(53, 39);
            this.btnPlaylist.TabIndex = 3;
            this.btnPlaylist.UseVisualStyleBackColor = false;
            this.btnPlaylist.Click += new System.EventHandler(this.BtnPlaylist_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Image = global::Media_Organiser.Properties.Resources._return;
            this.btnReturn.Location = new System.Drawing.Point(0, 7);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(53, 39);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // menuHeader
            // 
            this.menuHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuHeader.Controls.Add(this.btnMenu);
            this.menuHeader.Location = new System.Drawing.Point(735, 12);
            this.menuHeader.Name = "menuHeader";
            this.menuHeader.Size = new System.Drawing.Size(53, 39);
            this.menuHeader.TabIndex = 4;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = global::Media_Organiser.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(53, 39);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 10;
            this.menuTimer.Tick += new System.EventHandler(this.MenuTimer_Tick);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(12, 12);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(472, 20);
            this.txtDir.TabIndex = 6;
            // 
            // fileType
            // 
            this.fileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileType.FormattingEnabled = true;
            this.fileType.Items.AddRange(new object[] {
            "Select File Type",
            "*",
            ".AAC",
            ".MP3",
            ".WAV",
            ".MP4",
            ".AVI"});
            this.fileType.Location = new System.Drawing.Point(490, 11);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(136, 21);
            this.fileType.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 28);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Image = global::Media_Organiser.Properties.Resources.upload_dark_grey;
            this.btnUpload.Location = new System.Drawing.Point(659, 410);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(126, 28);
            this.btnUpload.TabIndex = 10;
            this.btnUpload.Text = "Upload Selected";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Media_Organiser.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(632, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 25);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.AllowUserToAddRows = false;
            this.lstFiles.AllowUserToDeleteRows = false;
            this.lstFiles.AllowUserToOrderColumns = true;
            this.lstFiles.AllowUserToResizeColumns = false;
            this.lstFiles.AllowUserToResizeRows = false;
            this.lstFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tblIcon,
            this.tblDir,
            this.tblFileName,
            this.tblFileExtension});
            this.lstFiles.Location = new System.Drawing.Point(12, 57);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.ReadOnly = true;
            this.lstFiles.RowHeadersVisible = false;
            this.lstFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstFiles.Size = new System.Drawing.Size(773, 347);
            this.lstFiles.TabIndex = 12;
            // 
            // tblIcon
            // 
            this.tblIcon.HeaderText = "Icon";
            this.tblIcon.Name = "tblIcon";
            this.tblIcon.ReadOnly = true;
            this.tblIcon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tblIcon.Width = 50;
            // 
            // tblDir
            // 
            this.tblDir.HeaderText = "Directory";
            this.tblDir.Name = "tblDir";
            this.tblDir.ReadOnly = true;
            this.tblDir.Visible = false;
            // 
            // tblFileName
            // 
            this.tblFileName.HeaderText = "File Name";
            this.tblFileName.Name = "tblFileName";
            this.tblFileName.ReadOnly = true;
            this.tblFileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tblFileName.Width = 600;
            // 
            // tblFileExtension
            // 
            this.tblFileExtension.HeaderText = "File Extension";
            this.tblFileExtension.Name = "tblFileExtension";
            this.tblFileExtension.ReadOnly = true;
            this.tblFileExtension.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FileUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.fileType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.menuBody);
            this.Controls.Add(this.menuHeader);
            this.Controls.Add(this.lstFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileUpload";
            this.Text = "File Upload";
            this.Load += new System.EventHandler(this.FileUpload_Load);
            this.menuBody.ResumeLayout(false);
            this.menuHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuBody;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel menuHeader;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox fileType;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView lstFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblFileExtension;
        private System.Windows.Forms.DataGridViewImageColumn tblIcon;
    }
}