namespace QuizApplicationSprintTwo
{
    partial class MoviePictureRounds
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionPic = new System.Windows.Forms.PictureBox();
            this.OptionOne = new QuizApplicationSprintTwo.MyButton();
            this.OptionTwo = new QuizApplicationSprintTwo.MyButton();
            this.OptionThree = new QuizApplicationSprintTwo.MyButton();
            this.OptionFour = new QuizApplicationSprintTwo.MyButton();
            this.OptionFive = new QuizApplicationSprintTwo.MyButton();
            this.OptionSix = new QuizApplicationSprintTwo.MyButton();
            this.QuestionDisp = new System.Windows.Forms.Label();
            this.Return = new QuizApplicationSprintTwo.MyButton();
            this.UnMute = new System.Windows.Forms.Button();
            this.Mute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPic)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionPic
            // 
            this.QuestionPic.Location = new System.Drawing.Point(88, 163);
            this.QuestionPic.Name = "QuestionPic";
            this.QuestionPic.Size = new System.Drawing.Size(1113, 563);
            this.QuestionPic.TabIndex = 0;
            this.QuestionPic.TabStop = false;
            // 
            // OptionOne
            // 
            this.OptionOne.BackColor = System.Drawing.Color.Crimson;
            this.OptionOne.FlatAppearance.BorderSize = 0;
            this.OptionOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionOne.ForeColor = System.Drawing.Color.White;
            this.OptionOne.Location = new System.Drawing.Point(241, 849);
            this.OptionOne.Name = "OptionOne";
            this.OptionOne.Size = new System.Drawing.Size(300, 80);
            this.OptionOne.TabIndex = 1;
            this.OptionOne.Tag = "1";
            this.OptionOne.Text = "myButton1";
            this.OptionOne.UseVisualStyleBackColor = false;
            this.OptionOne.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // OptionTwo
            // 
            this.OptionTwo.BackColor = System.Drawing.Color.Crimson;
            this.OptionTwo.FlatAppearance.BorderSize = 0;
            this.OptionTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionTwo.ForeColor = System.Drawing.Color.White;
            this.OptionTwo.Location = new System.Drawing.Point(742, 849);
            this.OptionTwo.Name = "OptionTwo";
            this.OptionTwo.Size = new System.Drawing.Size(300, 80);
            this.OptionTwo.TabIndex = 2;
            this.OptionTwo.Tag = "2";
            this.OptionTwo.Text = "myButton2";
            this.OptionTwo.UseVisualStyleBackColor = false;
            this.OptionTwo.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // OptionThree
            // 
            this.OptionThree.BackColor = System.Drawing.Color.Crimson;
            this.OptionThree.FlatAppearance.BorderSize = 0;
            this.OptionThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionThree.ForeColor = System.Drawing.Color.White;
            this.OptionThree.Location = new System.Drawing.Point(241, 999);
            this.OptionThree.Name = "OptionThree";
            this.OptionThree.Size = new System.Drawing.Size(300, 80);
            this.OptionThree.TabIndex = 3;
            this.OptionThree.Tag = "3";
            this.OptionThree.Text = "myButton3";
            this.OptionThree.UseVisualStyleBackColor = false;
            this.OptionThree.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // OptionFour
            // 
            this.OptionFour.BackColor = System.Drawing.Color.Crimson;
            this.OptionFour.FlatAppearance.BorderSize = 0;
            this.OptionFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionFour.ForeColor = System.Drawing.Color.White;
            this.OptionFour.Location = new System.Drawing.Point(742, 999);
            this.OptionFour.Name = "OptionFour";
            this.OptionFour.Size = new System.Drawing.Size(300, 80);
            this.OptionFour.TabIndex = 4;
            this.OptionFour.Tag = "4";
            this.OptionFour.Text = "myButton4";
            this.OptionFour.UseVisualStyleBackColor = false;
            this.OptionFour.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // OptionFive
            // 
            this.OptionFive.BackColor = System.Drawing.Color.Crimson;
            this.OptionFive.FlatAppearance.BorderSize = 0;
            this.OptionFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionFive.ForeColor = System.Drawing.Color.White;
            this.OptionFive.Location = new System.Drawing.Point(241, 1155);
            this.OptionFive.Name = "OptionFive";
            this.OptionFive.Size = new System.Drawing.Size(300, 80);
            this.OptionFive.TabIndex = 5;
            this.OptionFive.Tag = "5";
            this.OptionFive.Text = "myButton5";
            this.OptionFive.UseVisualStyleBackColor = false;
            this.OptionFive.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // OptionSix
            // 
            this.OptionSix.BackColor = System.Drawing.Color.Crimson;
            this.OptionSix.FlatAppearance.BorderSize = 0;
            this.OptionSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionSix.ForeColor = System.Drawing.Color.White;
            this.OptionSix.Location = new System.Drawing.Point(742, 1155);
            this.OptionSix.Name = "OptionSix";
            this.OptionSix.Size = new System.Drawing.Size(300, 80);
            this.OptionSix.TabIndex = 6;
            this.OptionSix.Tag = "6";
            this.OptionSix.Text = "myButton6";
            this.OptionSix.UseVisualStyleBackColor = false;
            this.OptionSix.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // QuestionDisp
            // 
            this.QuestionDisp.AutoSize = true;
            this.QuestionDisp.Location = new System.Drawing.Point(241, 774);
            this.QuestionDisp.Name = "QuestionDisp";
            this.QuestionDisp.Size = new System.Drawing.Size(78, 32);
            this.QuestionDisp.TabIndex = 7;
            this.QuestionDisp.Text = "label1";
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Crimson;
            this.Return.FlatAppearance.BorderSize = 0;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.ForeColor = System.Drawing.Color.White;
            this.Return.Location = new System.Drawing.Point(12, 12);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(178, 72);
            this.Return.TabIndex = 8;
            this.Return.Text = "Back";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // UnMute
            // 
            this.UnMute.BackgroundImage = global::QuizApplicationSprintTwo.Properties.Resources.PlayIcon;
            this.UnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UnMute.Location = new System.Drawing.Point(1116, 1361);
            this.UnMute.Name = "UnMute";
            this.UnMute.Size = new System.Drawing.Size(150, 100);
            this.UnMute.TabIndex = 11;
            this.UnMute.UseVisualStyleBackColor = true;
            this.UnMute.Click += new System.EventHandler(this.UnMute_Click);
            // 
            // Mute
            // 
            this.Mute.BackgroundImage = global::QuizApplicationSprintTwo.Properties.Resources.MuteIcon;
            this.Mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mute.Location = new System.Drawing.Point(1116, 1361);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(150, 100);
            this.Mute.TabIndex = 12;
            this.Mute.UseVisualStyleBackColor = true;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // MoviePictureRounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1278, 1537);
            this.Controls.Add(this.Mute);
            this.Controls.Add(this.UnMute);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.QuestionDisp);
            this.Controls.Add(this.OptionSix);
            this.Controls.Add(this.OptionFive);
            this.Controls.Add(this.OptionFour);
            this.Controls.Add(this.OptionThree);
            this.Controls.Add(this.OptionTwo);
            this.Controls.Add(this.OptionOne);
            this.Controls.Add(this.QuestionPic);
            this.Name = "MoviePictureRounds";
            this.Text = "MoviePictureRounds";
            this.Load += new System.EventHandler(this.MoviePictureRounds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox QuestionPic;
        private MyButton OptionOne;
        private MyButton OptionTwo;
        private MyButton OptionThree;
        private MyButton OptionFour;
        private MyButton OptionFive;
        private MyButton OptionSix;
        private Label QuestionDisp;
        private MyButton Return;
        private Button UnMute;
        private Button Mute;
    }
}