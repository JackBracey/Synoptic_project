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
            this.menuBody.SuspendLayout();
            this.menuHeader.SuspendLayout();
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
            // FileUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuBody);
            this.Controls.Add(this.menuHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileUpload";
            this.Text = "File Upload";
            this.Load += new System.EventHandler(this.FileUpload_Load);
            this.menuBody.ResumeLayout(false);
            this.menuHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuBody;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel menuHeader;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Timer menuTimer;
    }
}