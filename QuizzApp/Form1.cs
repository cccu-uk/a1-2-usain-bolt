using System.Threading;

namespace QuizzApp
{
    public partial class Form1 : Form
    {
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        static void newPage(Object obj)
        {
            Application.Run(new SinglePlayerOptions());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(newPage);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}