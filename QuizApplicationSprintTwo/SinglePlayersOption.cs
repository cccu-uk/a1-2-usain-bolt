using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplicationSprintTwo
{
    // Dev Andrew Wright
    public partial class SinglePlayersOption : Form
    {
        Thread mySwitch;
        public SinglePlayersOption()
        {
            InitializeComponent();
        }
        private void _VideoPictureRoundsStart(object obj)
        {
            Application.Run(new VideoGamePictureRounds());
        }

        private void _ReturnToHomePage(object obj)
        {
            Application.Run(new Form1());
        }

        private void _MovieRoundsStart(object obj)
        {
            Application.Run(new MoviePictureRounds());
        }

        private void MoviesPrStart_Click(object sender, EventArgs e)
        {
            this.Close();
            mySwitch = new Thread(_MovieRoundsStart);
            mySwitch.SetApartmentState((ApartmentState)ApartmentState.STA);
            mySwitch.Start();

        }

        private void VideoGamePrStart_Click(object sender, EventArgs e)
        {
            this.Close();
            mySwitch = new Thread(_VideoPictureRoundsStart);
            mySwitch.SetApartmentState(ApartmentState.STA);
            mySwitch.Start();
        }

        private void SinglePlayersOption_Load(object sender, EventArgs e)
        {
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            mySwitch = new Thread(_ReturnToHomePage);
            mySwitch.SetApartmentState(((ApartmentState)ApartmentState.STA));
            mySwitch.Start();

        }
    }
}
