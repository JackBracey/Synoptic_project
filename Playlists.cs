using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Media_Organiser
{
    public partial class Playlists : Form
    {

        bool isMenuOpen = false;

        public Playlists()
        {
            InitializeComponent();
        }
        private void Playlists_Load(object sender, EventArgs e)
        {
            menuBody.Height = 0;
            LoadAllPlaylists();
        }
        private void LoadAllPlaylists()
        {
            lstPlaylists.Rows.Clear();
            foreach (Dictionary<object, object> playlist in DatabaseManager.GetAllPlaylists())
            {
                lstPlaylists.Rows.Add(playlist.Keys, playlist.Values);
            }
        }
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
        }
        private void BtnUpload_Click(object sender, EventArgs e)
        {
            this.Hide();
            var uploadForm = new FileUpload();
            uploadForm.Show();
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new Main();
            mainForm.Show();
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

        private void BtnNewPlaylist_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPlaylistName.Text))
                MessageBox.Show("Enter a playlist name");
            else
            {
                DatabaseManager.AddPlaylist(txtPlaylistName.Text);
            }
        }

        private void BtnDeletePlaylist_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in lstPlaylists.SelectedRows)
            {

            }
            LoadAllPlaylists();
        }
    }
}
