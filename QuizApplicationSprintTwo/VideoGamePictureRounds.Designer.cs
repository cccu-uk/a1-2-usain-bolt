namespace QuizApplicationSprintTwo
{
    partial class VideoGamePictureRounds
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
            this.OptionOne = new QuizApplicationSprintTwo.MyButton();
            this.OptionTwo = new QuizApplicationSprintTwo.MyButton();
            this.OptionThree = new QuizApplicationSprintTwo.MyButton();
            this.OptionFour = new QuizApplicationSprintTwo.MyButton();
            this.OptionFive = new QuizApplicationSprintTwo.MyButton();
            this.OptionSix = new QuizApplicationSprintTwo.MyButton();
            this.QuestionPic = new System.Windows.Forms.PictureBox();
            this.Return = new QuizApplicationSprintTwo.MyButton();
            this.QuestionDisplay = new System.Windows.Forms.Label();
            this.Mute = new System.Windows.Forms.Button();
            this.UnMute = new System.Windows.Forms.Button();
            this.TimerTick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPic)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionOne
            // 
            this.OptionOne.BackColor = System.Drawing.Color.Crimson;
            this.OptionOne.FlatAppearance.BorderSize = 0;
            this.OptionOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionOne.ForeColor = System.Drawing.Color.White;
            this.OptionOne.Location = new System.Drawing.Point(130, 398);
            this.OptionOne.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.OptionOne.Name = "OptionOne";
            this.OptionOne.Size = new System.Drawing.Size(162, 38);
            this.OptionOne.TabIndex = 0;
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
            this.OptionTwo.Location = new System.Drawing.Point(400, 398);
            this.OptionTwo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.OptionTwo.Name = "OptionTwo";
            this.OptionTwo.Size = new System.Drawing.Size(162, 38);
            this.OptionTwo.TabIndex = 1;
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
            this.OptionThree.Location = new System.Drawing.Point(130, 475);
            this.OptionThree.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.OptionThree.Name = "OptionThree";
            this.OptionThree.Size = new System.Drawing.Size(162, 38);
            this.OptionThree.TabIndex = 2;
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
            this.OptionFour.Location = new System.Drawing.Point(400, 470);
            this.OptionFour.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.OptionFour.Name = "OptionFour";
            this.OptionFour.Size = new System.Drawing.Size(162, 38);
            this.OptionFour.TabIndex = 3;
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
            this.OptionFive.Location = new System.Drawing.Point(130, 549);
            this.OptionFive.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.OptionFive.Name = "OptionFive";
            this.OptionFive.Size = new System.Drawing.Size(162, 38);
            this.OptionFive.TabIndex = 4;
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
            this.OptionSix.Location = new System.Drawing.Point(400, 549);
            this.OptionSix.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.OptionSix.Name = "OptionSix";
            this.OptionSix.Size = new System.Drawing.Size(162, 38);
            this.OptionSix.TabIndex = 5;
            this.OptionSix.Tag = "6";
            this.OptionSix.Text = "myButton6";
            this.OptionSix.UseVisualStyleBackColor = false;
            this.OptionSix.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // QuestionPic
            // 
            this.QuestionPic.Image = global::QuizApplicationSprintTwo.Properties.Resources.Flight_sim;
            this.QuestionPic.Location = new System.Drawing.Point(47, 76);
            this.QuestionPic.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.QuestionPic.Name = "QuestionPic";
            this.QuestionPic.Size = new System.Drawing.Size(599, 264);
            this.QuestionPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuestionPic.TabIndex = 6;
            this.QuestionPic.TabStop = false;
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Crimson;
            this.Return.FlatAppearance.BorderSize = 0;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.ForeColor = System.Drawing.Color.White;
            this.Return.Location = new System.Drawing.Point(6, 0);
            this.Return.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(83, 30);
            this.Return.TabIndex = 7;
            this.Return.Text = "Back";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // QuestionDisplay
            // 
            this.QuestionDisplay.AutoSize = true;
            this.QuestionDisplay.Location = new System.Drawing.Point(130, 361);
            this.QuestionDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuestionDisplay.Name = "QuestionDisplay";
            this.QuestionDisplay.Size = new System.Drawing.Size(38, 15);
            this.QuestionDisplay.TabIndex = 8;
            this.QuestionDisplay.Text = "label1";
            // 
            // Mute
            // 
            this.Mute.BackgroundImage = global::QuizApplicationSprintTwo.Properties.Resources.MuteIcon;
            this.Mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mute.Location = new System.Drawing.Point(607, 672);
            this.Mute.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(81, 47);
            this.Mute.TabIndex = 9;
            this.Mute.UseVisualStyleBackColor = true;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // UnMute
            // 
            this.UnMute.BackgroundImage = global::QuizApplicationSprintTwo.Properties.Resources.PlayIcon;
            this.UnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UnMute.Location = new System.Drawing.Point(607, 672);
            this.UnMute.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.UnMute.Name = "UnMute";
            this.UnMute.Size = new System.Drawing.Size(81, 47);
            this.UnMute.TabIndex = 10;
            this.UnMute.UseVisualStyleBackColor = true;
            this.UnMute.Click += new System.EventHandler(this.UnMute_Click);
            // 
            // TimerTick
            // 
            this.TimerTick.AutoSize = true;
            this.TimerTick.Location = new System.Drawing.Point(325, 608);
            this.TimerTick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimerTick.Name = "TimerTick";
            this.TimerTick.Size = new System.Drawing.Size(38, 15);
            this.TimerTick.TabIndex = 11;
            this.TimerTick.Text = "label1";
            // 
            // VideoGamePictureRounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(742, 548);
            this.Controls.Add(this.TimerTick);
            this.Controls.Add(this.UnMute);
            this.Controls.Add(this.Mute);
            this.Controls.Add(this.QuestionDisplay);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.QuestionPic);
            this.Controls.Add(this.OptionSix);
            this.Controls.Add(this.OptionFive);
            this.Controls.Add(this.OptionFour);
            this.Controls.Add(this.OptionThree);
            this.Controls.Add(this.OptionTwo);
            this.Controls.Add(this.OptionOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "VideoGamePictureRounds";
            this.Text = "VideoGamePictureRounds";
            this.Load += new System.EventHandler(this.VideoGamePictureRounds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton OptionOne;
        private MyButton OptionTwo;
        private MyButton OptionThree;
        private MyButton OptionFour;
        private MyButton OptionFive;
        private MyButton OptionSix;
        private PictureBox QuestionPic;
        private MyButton Return;
        private Label QuestionDisplay;
        private Button Mute;
        private Button UnMute;
        private Label TimerTick;
    }
}