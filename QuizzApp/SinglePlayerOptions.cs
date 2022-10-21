using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzApp
{
    public partial class SinglePlayerOptions : Form
    {
        Thread thread;
        public SinglePlayerOptions()
        {
            InitializeComponent();
        }

        private void VideoGames_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(_MySwitchVideo);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static void _MySwitchVideo(object obj)
        {
            Application.Run(new Video_Game_Quiz());
        }

        static void _Return(object obj)
        {
            Application.Run(new Form1());
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(_Return);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }
    }
}
