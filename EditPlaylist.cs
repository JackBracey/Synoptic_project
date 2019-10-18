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
            LoadPlaylistSongs();
        }

        private void LoadPlaylistSongs()
        {
            if (!String.IsNullOrEmpty(name))
            {
                lstPlaylistSongs.Rows.Clear();
                txtPlaylistName.Text = name;
                foreach (Objects.Record record in DatabaseManager.GetSongsInPlaylist(name))
                    lstPlaylistSongs.Rows.Add(record.name, record.type);
            }
        }

        private void btnRemoveRecords_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in lstPlaylistSongs.SelectedRows)
            {
                DatabaseManager.RemoveRecordFromPlaylist(name, row.Cells[0].Value.ToString());
                LoadPlaylistSongs();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to delete this playlist", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!String.IsNullOrEmpty(name))
                {
                    DatabaseManager.DeletePlaylist(name);
                    this.Hide();
                }
            }
        }
    }
}
