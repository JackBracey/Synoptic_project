namespace Media_Organiser
{
    partial class EditPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPlaylist));
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.lstPlaylistSongs = new System.Windows.Forms.DataGridView();
            this.tblName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstPlaylistSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylistName.Location = new System.Drawing.Point(142, 20);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(284, 26);
            this.txtPlaylistName.TabIndex = 0;
            this.txtPlaylistName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstPlaylistSongs
            // 
            this.lstPlaylistSongs.AllowUserToAddRows = false;
            this.lstPlaylistSongs.AllowUserToDeleteRows = false;
            this.lstPlaylistSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPlaylistSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tblName,
            this.tblExtension});
            this.lstPlaylistSongs.Location = new System.Drawing.Point(28, 66);
            this.lstPlaylistSongs.Name = "lstPlaylistSongs";
            this.lstPlaylistSongs.ReadOnly = true;
            this.lstPlaylistSongs.RowHeadersVisible = false;
            this.lstPlaylistSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstPlaylistSongs.Size = new System.Drawing.Size(527, 239);
            this.lstPlaylistSongs.TabIndex = 1;
            // 
            // tblName
            // 
            this.tblName.HeaderText = "Media Name";
            this.tblName.Name = "tblName";
            this.tblName.ReadOnly = true;
            this.tblName.Width = 410;
            // 
            // tblExtension
            // 
            this.tblExtension.HeaderText = "Extension";
            this.tblExtension.Name = "tblExtension";
            this.tblExtension.ReadOnly = true;
            this.tblExtension.Width = 80;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Media_Organiser.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(28, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Playlist";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Media_Organiser.Properties.Resources.save3;
            this.btnSave.Location = new System.Drawing.Point(490, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // EditPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 353);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstPlaylistSongs);
            this.Controls.Add(this.txtPlaylistName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPlaylist";
            this.Text = "Edit Playlist";
            this.Load += new System.EventHandler(this.EditPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstPlaylistSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.DataGridView lstPlaylistSongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblExtension;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}