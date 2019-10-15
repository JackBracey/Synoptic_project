﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Media_Organiser
{
    public partial class FileUpload : Form
    {

        bool isMenuOpen = false;

        public FileUpload()
        {
            InitializeComponent();
        }

        private void FileUpload_Load(object sender, EventArgs e)
        {
            InitialiseValues();
        }

        private void InitialiseValues()
        {
            menuBody.Height = 0;
            fileType.SelectedIndex = 0;
            txtDir.Text = "";
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            if (isMenuOpen)
            {
                menuBody.Height -= 10;
                if (menuBody.Height <= 0)
                {
                    menuTimer.Stop();
                    isMenuOpen = false;
                }
            }
            else
            {
                menuBody.Height += 10;
                if (menuBody.Height >= 100)
                {
                    menuTimer.Stop();
                    isMenuOpen = true;
                }
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new Main();
            mainForm.Show();
        }

        private void BtnPlaylist_Click(object sender, EventArgs e)
        {
            this.Hide();
            var playlistForm = new Playlists();
            playlistForm.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDir.Text))
            {
                String dir = txtDir.Text;
                lstFiles.Rows.Clear();

                DirectoryInfo di = new DirectoryInfo(dir);
                FileInfo[] files = di.GetFiles();

                foreach(FileInfo file in files)
                {
                    if (fileType.Text.Equals("*")||fileType.Text.Equals("Select File Type")||
                        fileType.Text.ToLower().Equals(file.Extension.ToLower()))
                    {
                        Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                        lstFiles.Rows.Add(icon, file.Directory, file.Name, file.Extension);
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lstFiles.Rows.Clear();
            InitialiseValues();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            ArrayList failed = new ArrayList();
            foreach (DataGridViewRow row in lstFiles.SelectedRows)
            {
                Objects.Record record = DatabaseManager.UploadFile(row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
                if (record == null)
                    failed.Add(row.Cells[2].Value.ToString());
            }
            if (failed.Count >= 1)
                ShowPopup(failed);
        }

        private void ShowPopup(ArrayList failed)
        {
            
        }
    }
}
