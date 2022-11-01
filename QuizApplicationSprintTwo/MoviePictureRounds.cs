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
    public partial class MoviePictureRounds : Form
    {
        Thread mySwitch;
        
        int points;
        
        int questionNum = 1;
        
        int score;
        
        int total;
        
        int percent;

        public MoviePictureRounds()
        {
            InitializeComponent();


            genQuest(questionNum);

            total = 12;

        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            try
            {

                // verify whether the players answer is correct 

                var senderObj = (Button)sender;


                int tag = Convert.ToInt32(senderObj.Tag);

                if (tag == points)
                {
                    score++;
                }

                if (questionNum == total)
                {
                    percent = (int)Math.Round((double)(score * 100) / questionNum);

                    MessageBox.Show("You have reached the end \n" + "You answered" + score + "Correctly \n" + "Percentage equals" + percent);

                    if (MessageBox.Show("Play Again", "Would You Like to play again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        score = 0;
                        questionNum = 0;
                        genQuest(questionNum);
                    }

                    else
                    {
                        SoundPlayer gamingBackground = new SoundPlayer();
                        gamingBackground.SoundLocation = @".\Hotham - Need You.wav";
                        gamingBackground.Stop();

                        this.Close();
                        mySwitch = new Thread(_ReturnToPlayerOneOption);
                        mySwitch.SetApartmentState(ApartmentState.STA);
                        mySwitch.Start();

                    }
                }

                questionNum++;
                genQuest(questionNum);
            }

            // Fixed issue, however sometimes reoccures 

            catch (System.InvalidCastException)
            {
                MessageBox.Show("Internal error");
            }
        }

        private void genQuest(int j)
        {
            switch (j)
            {
                case 1:

                    QuestionPic.Image = Properties.Resources.Matrix;

                    QuestionDisp.Text = "What colour pill does Neo take in the matrix?";

                    OptionOne.Text = "Purple";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Blue";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Yellow";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;


                    OptionFour.Text = "Red";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 4;

                    break;

                case 2:

                    QuestionPic.Image = Properties.Resources.Marvel_Logo_svg;

                    QuestionDisp.Text = "What movie saved marvel from bankcruptcy";

                    OptionOne.Text = "Spiderman";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;
                    
                    OptionTwo.Text = "DareDevil";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Blade";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "Watchmen";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;
                    
                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 3;

                    break;
                
                case 3:
                    QuestionPic.Image = Properties.Resources.Godfather;

                    QuestionDisp.Text = "The head of what kind of animal is front-and-center in an infamous scene from The Godfather?";

                    OptionOne.Text = "Wolf";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Lion";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Eagle";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;
                    
                    OptionFour.Text = "Dog";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;
                    
                    OptionFive.Text = "Horse";
                    OptionFive.Visible = true;
                    OptionFive.Enabled = true;


                    OptionSix.Text = "Panther";
                    OptionSix.Visible = true;
                    OptionSix.Enabled = true;


                    points = 5;

                    break;

                case 4:

                    QuestionPic.Image = Properties.Resources.Steven_Spielberg;

                    QuestionDisp.Text = "For what movie did Steven Spielberg win his first Oscar for Best Director?";

                    OptionOne.Text = "War of The Worlds";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Schindler's List";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Saving Private Ryan";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "Indiana Jones and The Temple Of Doom";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Text = "TinTin";
                    OptionFive.Visible = true;
                    OptionFive.Enabled = true;

                    OptionSix.Text = "E.T. The Extra-Terrestrial";
                    OptionSix.Visible = true;
                    OptionSix.Enabled = true;

                    points = 2;


                    break;

                case 5:
                   
                    QuestionPic.Image = Properties.Resources.Lord;


                    QuestionDisp.Text = "Who is the only actor to receive an Oscar nomination for acting in a Lord of the Rings movie?";

                    OptionOne.Text = "Ian McKellen";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Elijah Wood";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Viggo Mortensen";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "Sean Astin";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionFive.Visible = false;
                    OptionSix.Enabled = false;

                    points = 1;

                    break;

                case 6:

                    QuestionPic.Image = Properties.Resources.Batman;

                    QuestionDisp.Text = "Who took over the role of Bruce Wayne's love interest Rachel Dawes in The Dark Knight, following Katie Holmes's exit after Batman Begins?";

                    OptionOne.Text = "Maggie Gyllenhaal";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Ruby Rose";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Visible = false;
                    OptionThree.Enabled = false;

                    OptionFour.Visible = false;
                    OptionFour.Enabled = false;

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 2;

                    break;

                case 7:

                    QuestionPic.Image = Properties.Resources.Halloween;

                    QuestionDisp.Text = "Who wrote the famous, scary theme music from Halloween?";

                    OptionOne.Text = "Danny Elfman";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Hans Zimmer";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "John Williams";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "John Carpenter";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 4;

                    break;

                case 8:

                    QuestionPic.Image = Properties.Resources.Apocalypsenow;

                    QuestionDisp.Text = "In Apocalypse Now, Robert Duvall says, \"I love the smell of _____ in the morning.";

                    OptionOne.Text = "War";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Coffee";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Fried Cheese";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "Ammo";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Text = "Napalm";
                    OptionFive.Visible = true;
                    OptionFive.Enabled = true;

                    OptionSix.Text = "Sweat";
                    OptionSix.Visible = true;
                    OptionSix.Enabled = true;

                    points = 5;

                    break;

                case 9:

                    QuestionPic.Image = Properties.Resources.Jaws;

                    QuestionDisp.Text = "What is the name of Quint's shark-hunting boat in Jaws?";

                    OptionOne.Text = "Poseidon";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "The chomper";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "The Merry Fisher";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "The Orca";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 4;


                    break;

                case 10:

                    QuestionPic.Image = Properties.Resources.Speed;

                    QuestionDisp.Text = "In the action thriller Speed, why is Annie (Sandra Bullock)'s driver's license suspended?";

                    OptionOne.Text = "Speeding";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "DUI";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Visible = false;
                    OptionThree.Enabled = false;

                    OptionFour.Visible = false;
                    OptionFour.Enabled = false;

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 1;

                    break;

                case 11:

                    QuestionPic.Image = Properties.Resources.Medi;

                    QuestionDisp.Text = "The Battle of Thermopylae served as the basis of what highly stylized smash hit swords-and-sandals action flick?";

                    OptionOne.Text = "Kingdom Of Heaven";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Troy";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "300";
                    OptionThree.Enabled = true;
                    OptionThree.Enabled= true;

                    OptionFour.Text = "The Last Kingdom";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 3;


                    break;



                case 12:


                    QuestionPic.Image = Properties.Resources.Villian;

                    QuestionDisp.Text = "What villian was most for saying notorious \" I Am Inevitable\" ";

                    OptionOne.Text = "Thor";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Wolverine";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Thanos";
                    OptionThree.Enabled = true;
                    OptionThree.Visible = true;

                    OptionFour.Text = "Darthvador";
                    OptionFour.Visible= true;
                    OptionFour.Enabled = true;
                    
                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    break;

            }


        }
        private void _ReturnToPlayerOneOption(object obj)
        {
            Application.Run(new SinglePlayersOption());
        }

        private void MoviePictureRounds_Load(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer gamingBackground = new SoundPlayer();
                gamingBackground.SoundLocation = @".\Hotham - Need You.wav";
                gamingBackground.PlayLooping();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Error Loading Media Files");
            }
        }

        private void UnMute_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer gamingBackground = new SoundPlayer();
                gamingBackground.SoundLocation = @".\Hotham - Need You.wav";
                gamingBackground.PlayLooping();

                UnMute.Visible = false;
                Mute.Visible = true;

            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Error Loading Media Files");
            }

        }

        private void Mute_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer gamingBackground = new SoundPlayer();
                gamingBackground.SoundLocation = @".\Hotham - Need You.wav";
                gamingBackground.Stop();

                Mute.Visible = false;
                UnMute.Visible = true;

            }

            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Error Loading Media Files");
            }

        }

        private void Return_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Your progress will be lost", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SoundPlayer gamingBackground = new SoundPlayer();
                gamingBackground.SoundLocation = @".\Hotham - Need You.wav";
                gamingBackground.Stop();

                this.Close();
                mySwitch = new Thread(_ReturnToPlayerOneOption);
                mySwitch.SetApartmentState(ApartmentState.STA);
                mySwitch.Start();
            }
            else
            {

            }
        }
    }   
}


