namespace Media_Organiser
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.menuHeader = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.menuBody = new System.Windows.Forms.Panel();
            this.lstRecords = new System.Windows.Forms.DataGridView();
            this.tblIcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // menuHeader
            // 
            this.menuHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuHeader.Controls.Add(this.btnMenu);
            this.menuHeader.Location = new System.Drawing.Point(674, 12);
            this.menuHeader.Name = "menuHeader";
            this.menuHeader.Size = new System.Drawing.Size(53, 39);
            this.menuHeader.TabIndex = 2;
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
            // lstRecords
            // 
            this.lstRecords.AllowUserToAddRows = false;
            this.lstRecords.AllowUserToDeleteRows = false;
            this.lstRecords.AllowUserToOrderColumns = true;
            this.lstRecords.AllowUserToResizeColumns = false;
            this.lstRecords.AllowUserToResizeRows = false;
            this.lstRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tblIcon,
            this.tblFileName,
            this.tblFileType});
            this.lstRecords.Location = new System.Drawing.Point(31, 57);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.ReadOnly = true;
            this.lstRecords.RowHeadersVisible = false;
            this.lstRecords.Size = new System.Drawing.Size(682, 339);
            this.lstRecords.TabIndex = 4;
            // 
            // tblIcon
            // 
            this.tblIcon.HeaderText = "Icon";
            this.tblIcon.Name = "tblIcon";
            this.tblIcon.ReadOnly = true;
            this.tblIcon.Width = 50;
            // 
            // tblFileName
            // 
            this.tblFileName.HeaderText = "File Name";
            this.tblFileName.Name = "tblFileName";
            this.tblFileName.ReadOnly = true;
            this.tblFileName.Width = 500;
            // 
            // tblFileType
            // 
            this.tblFileType.HeaderText = "File Type";
            this.tblFileType.Name = "tblFileType";
            this.tblFileType.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 444);
            this.Controls.Add(this.menuBody);
            this.Controls.Add(this.menuHeader);
            this.Controls.Add(this.lstRecords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Media Organiser";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuHeader.ResumeLayout(false);
            this.menuBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel menuHeader;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Panel menuBody;
        private System.Windows.Forms.DataGridView lstRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblFileType;
    }
}

