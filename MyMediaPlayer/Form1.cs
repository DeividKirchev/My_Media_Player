using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyMediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Movies.MouseHover += new EventHandler(Movies_MouseHover);
        }
        void Movies_MouseHover(object sender, EventArgs e)

        {

            Point pos = Movies.PointToClient(MousePosition);

            int index = Movies.IndexFromPoint(pos);

            if (index > -1)

            {

                pos = this.PointToClient(MousePosition);

                toolTip1.Show(Movies.Items[index].ToString(), this, pos.X, pos.Y, 5000);

            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          MoviePlayer.URL = @"C:\Users\david\Downloads\" + Movies.SelectedItem.ToString();
        }
        private void GetMovies (string s)
        {
            string[] list = Directory.GetFiles(@"C:\Users\david\Downloads\", s, SearchOption.AllDirectories);
            foreach (string file in list)
            {
                Movies.Items.Add(file.Remove(0,25));
            }
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            Movies.Items.Clear();
            GetMovies("*.mp3");
            GetMovies("*.mp4");
            GetMovies("*.3GP");
            GetMovies("*.AVI");
            GetMovies("*.AAC");
            GetMovies("*.AVCHD");
            GetMovies("*.MPEG-4");
            GetMovies("*.WMV");
            GetMovies("*.WMA");
            GetMovies("*.MOV");

        }
    }
}
