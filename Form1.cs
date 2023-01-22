using System;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayer : Form
    {

        String[] files, paths;
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            WindowsMediaPlayer1.URL = paths[Songs.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for (int x = 0; x < files.Length; x++)
                {
                    Songs.Items.Add(files[x]);
                }
            }
        }
    }
}
