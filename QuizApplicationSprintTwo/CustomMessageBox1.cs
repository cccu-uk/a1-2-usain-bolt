using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplicationSprintTwo
{
    public partial class CustomMessageBox1 : Form
    {
        public CustomMessageBox1()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return MessageDisp.Text;}
            set { MessageDisp.Text = value;}
        }
    }
}
