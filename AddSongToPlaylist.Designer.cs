namespace Media_Organiser
{
    partial class AddSongToPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSongToPlaylist));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstPlaylists = new System.Windows.Forms.DataGridView();
            this.tblPlaylist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNoRecords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstPlaylists)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(66, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(237, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // lstPlaylists
            // 
            this.lstPlaylists.AllowUserToAddRows = false;
            this.lstPlaylists.AllowUserToDeleteRows = false;
            this.lstPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPlaylists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tblPlaylist,
            this.tblNoRecords});
            this.lstPlaylists.Location = new System.Drawing.Point(31, 50);
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.ReadOnly = true;
            this.lstPlaylists.RowHeadersVisible = false;
            this.lstPlaylists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstPlaylists.Size = new System.Drawing.Size(392, 210);
            this.lstPlaylists.TabIndex = 2;
            // 
            // tblPlaylist
            // 
            this.tblPlaylist.HeaderText = "Playlist";
            this.tblPlaylist.Name = "tblPlaylist";
            this.tblPlaylist.ReadOnly = true;
            this.tblPlaylist.Width = 260;
            // 
            // tblNoRecords
            // 
            this.tblNoRecords.HeaderText = "No. Records";
            this.tblNoRecords.Name = "tblNoRecords";
            this.tblNoRecords.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Media_Organiser.Properties.Resources.save3;
            this.btnSave.Location = new System.Drawing.Point(348, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Media_Organiser.Properties.Resources.delete;
            this.button1.Location = new System.Drawing.Point(162, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove Selected Media";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Media_Organiser.Properties.Resources.delete;
            this.button2.Location = new System.Drawing.Point(31, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete Playlist";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::Media_Organiser.Properties.Resources.search;
            this.button3.Location = new System.Drawing.Point(309, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Search";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AddSongToPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 303);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstPlaylists);
            this.Controls.Add(this.txtSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSongToPlaylist";
            this.Text = "Add Song To Playlist";
            this.Load += new System.EventHandler(this.AddSongToPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstPlaylists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView lstPlaylists;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblPlaylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblNoRecords;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}