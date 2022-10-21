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
    public partial class Video_Game_Quiz : Form
    {
        int points;
        int questionNum = 1;
        int score;
        int total;
        int percentage;


        public Video_Game_Quiz()
        {
            InitializeComponent();

            genQuest(questionNum);

            total = 2;
        }

        private void PlayerAnswer(object sender, EventArgs e)
        {

            var senderObj = (Button)sender;

            int tag = Convert.ToInt32(senderObj.Tag);

            if (tag == points)
            {
                questionNum++;
                genQuest(questionNum);
            }

        }

        private void genQuest(int i)
        {
            switch (i)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Doom;

                    QuestionDisplay.Text = "What year was Doom first released";

                    OptionOne.Text = "1999";
                    OptionTwo.Text = "1980";
                    OptionThree.Text = "2017";
                    OptionFour.Text = "1993";

                    Enter.Hide();
                    InputAnswer.Hide();

                    points = 4;

                    break;

                case 2:

                    string correctAnswer = "ghost Wire: toyko";
                    string correctAnswerAlt = "ghost wire toyko";
                    
                    pictureBox1.Image = Properties.Resources.Bethesda;

                    QuestionDisplay.Text = "What is the name of Bethesdas newest released";

                    OptionOne.Hide();
                    OptionTwo.Hide();
                    OptionThree.Hide();
                    OptionFour.Hide();

                    Enter.Show();
                    InputAnswer.Show();

                    string playerAnswer = InputAnswer.Text.ToLower();

                    if (string.IsNullOrEmpty(playerAnswer))
                    {
                        MessageBox.Show("Please enter your answer");
                    }

                    if (playerAnswer == correctAnswer || playerAnswer == correctAnswerAlt)
                    {
                        points = 1;
                    }

                    break;
            }
            
        }
    }
}
