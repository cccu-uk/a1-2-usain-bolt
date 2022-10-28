using System.Media;
using System.Threading;


namespace QuizApplicationSprintTwo
{
    public partial class Form1 : Form
    {
        Thread mySwitch;
        public Form1()
        {
            InitializeComponent();
        }

        private void _OpenSinglePlayer(object obj)
        {
            Application.Run(new SinglePlayersOption());
        }

        private void SinglePlayerOptions_Click(object sender, EventArgs e)
        {
            this.Close();
            mySwitch = new Thread(_OpenSinglePlayer);
            mySwitch.SetApartmentState(ApartmentState.STA);
            mySwitch.Start();
        }

        private void MultiplayerOptions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Royalty free music https://pixabay.com/music/search/quiz/
            try
            {
                SoundPlayer gamingBackground = new SoundPlayer();
                gamingBackground.SoundLocation = @".\quiz-121408.wav";
                gamingBackground.PlayLooping();
            }

            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Error loading media files");
                
            }
            

            
        }
    }
}