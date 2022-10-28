using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using System.Media;
using static System.Net.WebRequestMethods;
using System.Diagnostics.Metrics;


namespace QuizApplicationSprintTwo
{
    // Dev = Andrew Wright 
    public partial class VideoGamePictureRounds : Form
    {
        Thread mySwitch;
        
        int points;
        
        int questionNum = 1;
        
        int score;
        
        int total;
        
        int percent;

        private System.Windows.Forms.Timer timer1;

        public VideoGamePictureRounds()
        {
            InitializeComponent();

            genQuest(questionNum);

            total = 20;


        }



        private void gameTimer(object sender, EventArgs e)
        {

            
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
        private void runGame()
        {
            var randomList = questionNum.ToString().OrderBy(x => x).ToList();

        }


        private void genQuest(int j)
        {

            switch (j)
            {
                case 1:

                    QuestionPic.Image = Properties.Resources.Doom;

                    QuestionDisplay.Text = "What year did the very first Doom game get released??";

                    OptionOne.Text = "1999";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "1980";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;
                    
                    OptionThree.Text = "2017";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "1993";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;
                    

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;



                    points = 4;


                    break;

                case 2:

                    QuestionPic.Image = Properties.Resources.gaming_illustration;

                    QuestionDisplay.Text = "What was the very first gaming console released called??";

                    OptionOne.Text = "Playstation";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Xbox";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "the Magnavox Odyssey";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "Saga MegaDrive";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Visible= false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible= false;
                    OptionSix.Enabled = false;

                    points = 1;


                    break;

                case 3:

                    QuestionPic.Image = Properties.Resources.Bethesda;

                    QuestionDisplay.Text = "What is the lastest release from Bethesda";

                    OptionOne.Text = "Fallout 76";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Starfield";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Ghost Wire: Tokyo";

                    OptionFour.Text = "Elder Scrolls";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 3;

                    break;

                case 4:

                    QuestionPic.Image = Properties.Resources.AGB_WZ_0309_TOUT;

                    QuestionDisplay.Text = "What genre is Call of Duty Warzone";

                    OptionOne.Text = "MMO";
                    OptionOne.Visible= true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Battle Royal";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "FPS";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "RPG";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 2;

                    break;

                case 5:

                    QuestionPic.Image = Properties.Resources.GrandTheftAuto;

                    QuestionDisplay.Text = "How many GTA games have been released";

                    OptionOne.Text = "4";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "7";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "5";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "6";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 3;

                    break;

                case 6:

                    QuestionPic.Image = Properties.Resources.gold_label_best_seller_vector_9319985;

                    QuestionDisplay.Text = "What is the best selling video game of all time";

                    OptionOne.Text = "Fortnight";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Elder Scrolls";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Dark Souls";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "Sonic The Hedgehog";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Text = "MineCraft";
                    OptionFive.Visible = true;
                    OptionFive.Enabled = true;

                    OptionSix.Text = "Mario";
                    OptionSix.Visible = true;
                    OptionSix.Enabled = true;

                    points = 5;


                    break;

                case 7:

                    QuestionPic.Image = Properties.Resources.SI_GenericNintendo;

                    QuestionDisplay.Text = ("What year was Nintendo founded??");

                    OptionOne.Text = "1979";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "1996";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "1974";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "1985";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Text = "1990";
                    OptionFive.Visible = true;
                    OptionFive.Enabled = true;

                    OptionSix.Text = "1898";
                    OptionSix.Visible = true;
                    OptionSix.Enabled = true;

                    points = 6;


                    break;

                case 8:

                    QuestionPic.Image = Properties.Resources.Blizzard_Entertainment;

                    QuestionDisplay.Text = "Blizzard Entertainment is most well known for what video game franchise?";

                    OptionOne.Text = "Overwatch";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Overwatch 2";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Diablo III";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "World Of Warcraft";
                    OptionFive.Visible = true;
                    OptionFive.Enabled = true;

                    OptionFive.Text = "Heros Of The Storm";
                    OptionFive.Visible = true;
                    OptionFive.Enabled = true;

                    OptionSix.Text = "Hearthstone";
                    OptionSix.Visible = true;
                    OptionSix.Enabled = true;


                    points = 4;

                    break;

                case 9:

                    QuestionPic.Image = Properties.Resources.Donkey_Kong_Character_N2;

                    QuestionDisplay.Text = "In the original arcade version of Donkey Kong, what was the name of the character that would later be known as Mario?";

                    OptionOne.Text = "The Plumber";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Jump Man";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Sir Tash";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "King of the barrels";
                    OptionFive.Visible = true;
                    OptionFive.Enabled = true;

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 4;

                    break;

                case 10:

                    QuestionPic.Image = Properties.Resources.steam_getty_ringer_0;

                    QuestionDisplay.Text = "What is the best selling hand held gaming device??";

                    OptionOne.Text = "Nintendo DS";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Sony PSP";
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

                    QuestionPic.Image = Properties.Resources.Money;

                    QuestionDisplay.Text = "What is the most expensive video game made to date??";

                    OptionOne.Text = "Call Of Duty Modern Warfare";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Minecraft";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Elden Ring";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "Fallout 76";
                    OptionFive.Visible = true;
                    OptionFive.Enabled = true;

                    OptionFive.Text = "GTA V";
                    OptionFive.Visible = true;
                    OptionFive.Enabled = true;

                    OptionSix.Text = "The Last of Us";
                    OptionSix.Visible = true;
                    OptionSix.Enabled = true;

                    points = 5;

                    break;

                case 12:

                    QuestionPic.Image = Properties.Resources.H2x1_GameBoy_support_no_logo;

                    QuestionDisplay.Text = "What position did the creator of the Game Boy have at Nintendo?";

                    OptionOne.Text = "Software dev";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Janitor";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Engineer";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;
                    
                    OptionFour.Text = "Team leader";
                    OptionFive.Visible = true;
                    OptionFive.Enabled = true;

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 2;

                    break;

                case 13:

                    QuestionPic.Image = Properties.Resources.Flight_sim;

                    QuestionDisplay.Text = "Who released the first flight simulator game?";

                    OptionOne.Text = "Microsoft";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "IBM";
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

                case 14:

                    QuestionPic.Image = Properties.Resources.Vr;

                    QuestionDisplay.Text = "What year was the first virtual reality headset created";

                    OptionOne.Text = "1995";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "1998";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "1979";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "2000";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Text = "2002";
                    OptionFive.Visible = true;
                    OptionFive.Enabled = true;

                    OptionSix.Text = "2009";
                    OptionSix.Visible = true;
                    OptionSix.Enabled = true;

                    points = 1;

                    break;

                case 15:

                    QuestionPic.Image = Properties.Resources.SI_GenericNintendo;

                    QuestionDisplay.Text = "What product did Nintendo first release before taking on the world of video games?";

                    OptionOne.Text = "Board games";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Playing cards";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Visible= false;
                    OptionThree.Enabled= false;

                    OptionFour.Visible= false;
                    OptionFive.Enabled = false;

                    OptionFive.Visible= false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible= false;
                    OptionSix.Enabled = false;

                    points = 2;

                    break;

                case 16:

                    QuestionPic.Image = Properties.Resources.Playstation;

                    QuestionDisplay.Text = "What video game company collaborated with SONY on the Playstation?";

                    OptionOne.Text = "Xbox";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "Nintendo";
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

                case 17:

                    QuestionPic.Image = Properties.Resources.Pokemon;

                    QuestionDisplay.Text = "What inspired game maker Satoshi Tajiri to create the character Pokemon?";

                    OptionOne.Text = "Dogs";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;
                    
                    OptionTwo.Text = "Birds";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Snakes";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "Cats";
                    OptionFour.Visible= true;
                    OptionFour.Enabled = true;

                    OptionFive.Text = "Butterflies";
                    OptionFive.Visible = true;
                    OptionFive.Enabled = true;
                   
                    OptionSix.Text = "Moths";
                    OptionSix.Visible = true;
                    OptionSix.Enabled = true;


                    points = 5;

                    break;

                case 18:

                    QuestionPic.Image = Properties.Resources.Minecraft;

                    QuestionDisplay.Text = "What are the paintings in Minecraft modeled after?";

                    OptionOne.Text = "Paris";
                    OptionOne.Visible = true;
                    OptionOne.Enabled = true;

                    OptionTwo.Text = "The Devil May Cry";
                    OptionTwo.Visible = true;
                    OptionTwo.Enabled = true;

                    OptionThree.Text = "Counterstrike maps";
                    OptionThree.Visible = true;
                    OptionThree.Enabled = true;

                    OptionFour.Text = "Farming sims";
                    OptionFour.Visible = true;
                    OptionFour.Enabled = true;

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;
                       
                    OptionSix.Visible= false;
                    OptionSix.Enabled= false;

                    points = 3;

                    break;

                case 19:

                    QuestionPic.Image = Properties.Resources.Justice;

                    QuestionDisplay.Text = "What video game franchise has racked up over 1 Billion dollars in lawsuits?";

                    OptionOne.Text = "Hitman";
                    OptionTwo.Text = "Call of Duty";
                    OptionThree.Text = "Fear";
                    OptionFour.Text = "GTA";

                    OptionFive.Visible= false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 4;

                    break;

                case 20:

                    QuestionPic.Image = Properties.Resources.GOW;

                    QuestionDisplay.Text = "What is the name of the planet that is home to the game “Gears of War?";

                    OptionOne.Text = "Earth";
                    OptionTwo.Text = "The Rock";
                    OptionThree.Text = "Sera";
                    OptionFour.Text = "Mars";

                    OptionFive.Visible = false;
                    OptionFive.Enabled = false;

                    OptionSix.Visible = false;
                    OptionSix.Enabled = false;

                    points = 3;

                    break;

            }
        }

        private void _ReturnToPlayerOneOption(object obj)
        {
            Application.Run(new SinglePlayersOption());
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

        private void VideoGamePictureRounds_Load(object sender, EventArgs e)
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
    }
}
