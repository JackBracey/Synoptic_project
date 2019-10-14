using System;
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
            menuBody.Height = 0;
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
    }
}
