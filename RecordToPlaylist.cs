using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Media_Organiser
{
    public partial class RecordToPlaylist : Form
    {

        private ArrayList songNames;

        public RecordToPlaylist(ArrayList names)
        {
            InitializeComponent();
            songNames = names;
            LoadAllPlaylists();
        }

        private void LoadAllPlaylists()
        {
            lstPlaylists.Rows.Clear();
            foreach (Dictionary<Objects.Playlist, int> playlist in DatabaseManager.GetAllPlaylists())
                foreach (KeyValuePair<Objects.Playlist, int> item in playlist)
                    lstPlaylists.Rows.Add(item.Key.name, item.Value);
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this playlist?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseManager.DeletePlaylist(lstPlaylists.SelectedRows[0].Cells[0].Value.ToString());
                LoadAllPlaylists();
            }
        }

        private void btnSelectPlaylist_Click(object sender, EventArgs e)
        {
            if (lstPlaylists.SelectedRows != null)
            {
                string playlist = lstPlaylists.SelectedRows[0].Cells[0].Value.ToString();
                if (MessageBox.Show("Are you sure you want to add songs to playlist: " + playlist, "Adding songs to playlist", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (songNames.Count >= 1)
                    {
                        DatabaseManager.SetRecordToPlaylist(playlist, songNames);
                        LoadAllPlaylists();
                    }
                }
            }
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

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            this.Hide();
            var playlists = new Playlists();
            playlists.Show();
        }
    }
}
