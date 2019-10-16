using System;
using System.Windows.Forms;

namespace Media_Organiser
{
    public partial class EditPlaylist : Form
    {

        private string name;

        public EditPlaylist(string playlistName)
        {
            InitializeComponent();
            name = playlistName;
        }

        private void EditPlaylist_Load(object sender, EventArgs e)
        {
            LoadPlaylistSongs(name);
        }

        private void LoadPlaylistSongs(string playlistName)
        {
            if (!String.IsNullOrEmpty(playlistName))
            {
                txtPlaylistName.Text = playlistName;
                foreach (Objects.Record record in DatabaseManager.GetSongsInPlaylist(playlistName))
                    lstPlaylistSongs.Rows.Add(record.name, record.type);
            }
        }
    }
}
