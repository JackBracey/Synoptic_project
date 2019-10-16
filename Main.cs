using System;
using System.Collections;
using System.Windows.Forms;

namespace Media_Organiser
{
    public partial class Main : Form
    {

        bool isMenuOpen = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            menuBody.Height = 0;
            ShowAllRecords();
        }

        private void ShowAllRecords()
        {
            lstRecords.Rows.Clear();
            foreach (Objects.Record record in DatabaseManager.GetAllRecords())
            {
                lstRecords.Rows.Add(record.path, record.name, record.type);
            }
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
            } else {
                menuBody.Height += 10;
                if (menuBody.Height >= 100)
                {
                    menuTimer.Stop();
                    isMenuOpen = true;
                }
            }
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            this.Hide();
            var uploadForm = new FileUpload();
            uploadForm.Show();
        }

        private void BtnPlaylist_Click(object sender, EventArgs e)
        {
            this.Hide();
            var playlistForm = new Playlists();
            playlistForm.Show();
        }

        private void BtnRemoveSelected_Click(object sender, EventArgs e)
        {
            ArrayList selected = new ArrayList();
            foreach (DataGridViewRow row in lstRecords.SelectedRows)
            {
                selected.Add(row.Cells[1].Value.ToString()+@"\"+row.Cells[2].Value.ToString());
            }
            if (selected.Count >= 1)
            {
                DatabaseManager.RemoveRecords(selected);
                ShowAllRecords();
            }
        }

        private void BtnAddToPlaylist_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

            foreach (DataGridViewRow row in lstRecords.SelectedRows)
                list.Add(row.Cells[1].Value.ToString());

            var recordToPlaylist = new RecordToPlaylist(list);
            recordToPlaylist.Show();
        }
    }
}
