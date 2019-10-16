﻿namespace Media_Organiser
{
    partial class RecordToPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordToPlaylist));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstPlaylists = new System.Windows.Forms.DataGridView();
            this.btnSelectPlaylist = new System.Windows.Forms.Button();
            this.tblName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNumberOfRecords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstPlaylists)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(105, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(297, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Media_Organiser.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(426, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lstPlaylists
            // 
            this.lstPlaylists.AllowUserToAddRows = false;
            this.lstPlaylists.AllowUserToDeleteRows = false;
            this.lstPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPlaylists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tblName,
            this.tblNumberOfRecords});
            this.lstPlaylists.Location = new System.Drawing.Point(29, 45);
            this.lstPlaylists.MultiSelect = false;
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.ReadOnly = true;
            this.lstPlaylists.RowHeadersVisible = false;
            this.lstPlaylists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstPlaylists.Size = new System.Drawing.Size(572, 293);
            this.lstPlaylists.TabIndex = 2;
            // 
            // btnSelectPlaylist
            // 
            this.btnSelectPlaylist.Location = new System.Drawing.Point(477, 347);
            this.btnSelectPlaylist.Name = "btnSelectPlaylist";
            this.btnSelectPlaylist.Size = new System.Drawing.Size(124, 23);
            this.btnSelectPlaylist.TabIndex = 3;
            this.btnSelectPlaylist.Text = "Select Playlist";
            this.btnSelectPlaylist.UseVisualStyleBackColor = true;
            this.btnSelectPlaylist.Click += new System.EventHandler(this.btnSelectPlaylist_Click);
            // 
            // tblName
            // 
            this.tblName.HeaderText = "Playlist Name";
            this.tblName.Name = "tblName";
            this.tblName.ReadOnly = true;
            this.tblName.Width = 440;
            // 
            // tblNumberOfRecords
            // 
            this.tblNumberOfRecords.HeaderText = "No. Records";
            this.tblNumberOfRecords.Name = "tblNumberOfRecords";
            this.tblNumberOfRecords.ReadOnly = true;
            this.tblNumberOfRecords.Width = 90;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Image = global::Media_Organiser.Properties.Resources.delete;
            this.btnRemoveSelected.Location = new System.Drawing.Point(29, 347);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(124, 23);
            this.btnRemoveSelected.TabIndex = 4;
            this.btnRemoveSelected.Text = "Remove selected";
            this.btnRemoveSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // RecordToPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 382);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnSelectPlaylist);
            this.Controls.Add(this.lstPlaylists);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecordToPlaylist";
            this.Text = "Add Record To Playlist";
            ((System.ComponentModel.ISupportInitialize)(this.lstPlaylists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView lstPlaylists;
        private System.Windows.Forms.Button btnSelectPlaylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblNumberOfRecords;
        private System.Windows.Forms.Button btnRemoveSelected;
    }
}