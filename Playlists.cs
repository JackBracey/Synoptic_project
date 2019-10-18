using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            foreach (Dictionary<Objects.Playlist, int> playlist in DatabaseManager.GetAllPlaylists())
                foreach(KeyValuePair<Objects.Playlist, int> item in playlist)
                    lstPlaylists.Rows.Add(item.Key.name, item.Value);
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

            if (!String.IsNullOrEmpty(txtPlaylistName.Text))
            {
                if (MessageBox.Show("Are you sure you want to add " + txtPlaylistName.Text, "Confirmation",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatabaseManager.AddPlaylist(txtPlaylistName.Text);
                    LoadAllPlaylists();
                    txtPlaylistName.Text = "";
                }
            } else
                MessageBox.Show("Enter a playlist name");
        }

        private void BtnDeletePlaylist_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this playlist", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in lstPlaylists.SelectedRows)
                    DatabaseManager.DeletePlaylist(row.Cells[0].Value.ToString());
                LoadAllPlaylists();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllPlaylists();
        }

        private void btnEditPlaylist_Click(object sender, EventArgs e)
        {
            var editPlaylist = new EditPlaylist(lstPlaylists.SelectedRows[0].Cells[0].Value.ToString());
            editPlaylist.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstPlaylists.Rows.Clear();
            if (!String.IsNullOrEmpty(txtSearch.Text))
            {
                foreach (Dictionary<Objects.Playlist, int> playlist in DatabaseManager.GetPlaylistsFiltered(txtSearch.Text))
                    foreach (KeyValuePair<Objects.Playlist, int> item in playlist)
                        lstPlaylists.Rows.Add(item.Key.name, item.Value);
            }
            else
                LoadAllPlaylists();
        }
    }
}
