﻿namespace Media_Organiser
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.menuHeader = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.menuBody = new System.Windows.Forms.Panel();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lstRecords = new System.Windows.Forms.DataGridView();
            this.tblDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToPlaylist = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuHeader.SuspendLayout();
            this.menuBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 10;
            this.menuTimer.Tick += new System.EventHandler(this.MenuTimer_Tick);
            // 
            // menuHeader
            // 
            this.menuHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuHeader.Controls.Add(this.btnMenu);
            this.menuHeader.Location = new System.Drawing.Point(674, 12);
            this.menuHeader.Name = "menuHeader";
            this.menuHeader.Size = new System.Drawing.Size(53, 39);
            this.menuHeader.TabIndex = 2;
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
            // menuBody
            // 
            this.menuBody.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuBody.Controls.Add(this.btnPlaylist);
            this.menuBody.Controls.Add(this.btnUpload);
            this.menuBody.Location = new System.Drawing.Point(674, 50);
            this.menuBody.Name = "menuBody";
            this.menuBody.Size = new System.Drawing.Size(53, 100);
            this.menuBody.TabIndex = 3;
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
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Image = global::Media_Organiser.Properties.Resources.upload;
            this.btnUpload.Location = new System.Drawing.Point(0, 7);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(53, 39);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // lstRecords
            // 
            this.lstRecords.AllowUserToAddRows = false;
            this.lstRecords.AllowUserToDeleteRows = false;
            this.lstRecords.AllowUserToOrderColumns = true;
            this.lstRecords.AllowUserToResizeColumns = false;
            this.lstRecords.AllowUserToResizeRows = false;
            this.lstRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tblDir,
            this.tblFileName,
            this.tblFileType});
            this.lstRecords.Location = new System.Drawing.Point(31, 57);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.ReadOnly = true;
            this.lstRecords.RowHeadersVisible = false;
            this.lstRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstRecords.Size = new System.Drawing.Size(682, 339);
            this.lstRecords.TabIndex = 4;
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
            this.tblFileName.Width = 550;
            // 
            // tblFileType
            // 
            this.tblFileType.HeaderText = "File Type";
            this.tblFileType.Name = "tblFileType";
            this.tblFileType.ReadOnly = true;
            // 
            // btnAddToPlaylist
            // 
            this.btnAddToPlaylist.Image = global::Media_Organiser.Properties.Resources.playlist_dark;
            this.btnAddToPlaylist.Location = new System.Drawing.Point(559, 402);
            this.btnAddToPlaylist.Name = "btnAddToPlaylist";
            this.btnAddToPlaylist.Size = new System.Drawing.Size(154, 23);
            this.btnAddToPlaylist.TabIndex = 5;
            this.btnAddToPlaylist.Text = "Add Selected To Playlist";
            this.btnAddToPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddToPlaylist.UseVisualStyleBackColor = true;
            this.btnAddToPlaylist.Click += new System.EventHandler(this.BtnAddToPlaylist_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Image = global::Media_Organiser.Properties.Resources.delete;
            this.btnRemoveSelected.Location = new System.Drawing.Point(428, 402);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(125, 23);
            this.btnRemoveSelected.TabIndex = 6;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.BtnRemoveSelected_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(137, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(416, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Media_Organiser.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(559, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 444);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnAddToPlaylist);
            this.Controls.Add(this.menuBody);
            this.Controls.Add(this.menuHeader);
            this.Controls.Add(this.lstRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Media Organiser";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuHeader.ResumeLayout(false);
            this.menuBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel menuHeader;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Panel menuBody;
        private System.Windows.Forms.DataGridView lstRecords;
        private System.Windows.Forms.Button btnAddToPlaylist;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblFileType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

