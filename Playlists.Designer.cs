namespace Media_Organiser
{
    partial class Playlists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlists));
            this.menuBody = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.menuHeader = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.lstPlaylists = new System.Windows.Forms.DataGridView();
            this.tblName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNoRecords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewPlaylist = new System.Windows.Forms.Button();
            this.btnEditPlaylist = new System.Windows.Forms.Button();
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.btnDeletePlaylist = new System.Windows.Forms.Button();
            this.menuBody.SuspendLayout();
            this.menuHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPlaylists)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBody
            // 
            this.menuBody.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuBody.Controls.Add(this.btnMain);
            this.menuBody.Controls.Add(this.btnUpload);
            this.menuBody.Location = new System.Drawing.Point(735, 50);
            this.menuBody.Name = "menuBody";
            this.menuBody.Size = new System.Drawing.Size(53, 100);
            this.menuBody.TabIndex = 5;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Image = global::Media_Organiser.Properties.Resources._return;
            this.btnMain.Location = new System.Drawing.Point(0, 52);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(53, 39);
            this.btnMain.TabIndex = 3;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.BtnMain_Click);
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
            // lstPlaylists
            // 
            this.lstPlaylists.AllowUserToAddRows = false;
            this.lstPlaylists.AllowUserToDeleteRows = false;
            this.lstPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPlaylists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tblName,
            this.tblNoRecords});
            this.lstPlaylists.Location = new System.Drawing.Point(28, 57);
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.ReadOnly = true;
            this.lstPlaylists.RowHeadersVisible = false;
            this.lstPlaylists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstPlaylists.Size = new System.Drawing.Size(745, 342);
            this.lstPlaylists.TabIndex = 6;
            // 
            // tblName
            // 
            this.tblName.HeaderText = "Name";
            this.tblName.Name = "tblName";
            this.tblName.ReadOnly = true;
            this.tblName.Width = 610;
            // 
            // tblNoRecords
            // 
            this.tblNoRecords.HeaderText = "Number Of Records";
            this.tblNoRecords.Name = "tblNoRecords";
            this.tblNoRecords.ReadOnly = true;
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.Image = global::Media_Organiser.Properties.Resources.add;
            this.btnNewPlaylist.Location = new System.Drawing.Point(560, 405);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Size = new System.Drawing.Size(112, 23);
            this.btnNewPlaylist.TabIndex = 8;
            this.btnNewPlaylist.Text = "Add New Playlist";
            this.btnNewPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewPlaylist.UseVisualStyleBackColor = true;
            this.btnNewPlaylist.Click += new System.EventHandler(this.BtnNewPlaylist_Click);
            // 
            // btnEditPlaylist
            // 
            this.btnEditPlaylist.Image = global::Media_Organiser.Properties.Resources.edit;
            this.btnEditPlaylist.Location = new System.Drawing.Point(678, 405);
            this.btnEditPlaylist.Name = "btnEditPlaylist";
            this.btnEditPlaylist.Size = new System.Drawing.Size(95, 23);
            this.btnEditPlaylist.TabIndex = 7;
            this.btnEditPlaylist.Text = "Edit Selected";
            this.btnEditPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditPlaylist.UseVisualStyleBackColor = true;
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaylistName.Location = new System.Drawing.Point(319, 406);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(235, 20);
            this.txtPlaylistName.TabIndex = 9;
            // 
            // btnDeletePlaylist
            // 
            this.btnDeletePlaylist.Image = global::Media_Organiser.Properties.Resources.delete;
            this.btnDeletePlaylist.Location = new System.Drawing.Point(216, 405);
            this.btnDeletePlaylist.Name = "btnDeletePlaylist";
            this.btnDeletePlaylist.Size = new System.Drawing.Size(97, 23);
            this.btnDeletePlaylist.TabIndex = 10;
            this.btnDeletePlaylist.Text = "Delete Playlist";
            this.btnDeletePlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletePlaylist.UseVisualStyleBackColor = true;
            this.btnDeletePlaylist.Click += new System.EventHandler(this.BtnDeletePlaylist_Click);
            // 
            // Playlists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.btnDeletePlaylist);
            this.Controls.Add(this.txtPlaylistName);
            this.Controls.Add(this.btnNewPlaylist);
            this.Controls.Add(this.btnEditPlaylist);
            this.Controls.Add(this.menuBody);
            this.Controls.Add(this.menuHeader);
            this.Controls.Add(this.lstPlaylists);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Playlists";
            this.Text = "Playlists";
            this.Load += new System.EventHandler(this.Playlists_Load);
            this.menuBody.ResumeLayout(false);
            this.menuHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstPlaylists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuBody;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Panel menuHeader;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.DataGridView lstPlaylists;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblNoRecords;
        private System.Windows.Forms.Button btnEditPlaylist;
        private System.Windows.Forms.Button btnNewPlaylist;
        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.Button btnDeletePlaylist;
    }
}