namespace QuizzApp
{
    partial class Video_Game_Quiz
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
            this.OptionOne = new System.Windows.Forms.Button();
            this.OptionTwo = new System.Windows.Forms.Button();
            this.OptionThree = new System.Windows.Forms.Button();
            this.OptionFour = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QuestionDisplay = new System.Windows.Forms.Label();
            this.InputAnswer = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionOne
            // 
            this.OptionOne.Location = new System.Drawing.Point(474, 1032);
            this.OptionOne.Name = "OptionOne";
            this.OptionOne.Size = new System.Drawing.Size(150, 46);
            this.OptionOne.TabIndex = 0;
            this.OptionOne.Tag = "1";
            this.OptionOne.Text = "button1";
            this.OptionOne.UseVisualStyleBackColor = true;
            this.OptionOne.Click += new System.EventHandler(this.PlayerAnswer);
            // 
            // OptionTwo
            // 
            this.OptionTwo.Location = new System.Drawing.Point(917, 1032);
            this.OptionTwo.Name = "OptionTwo";
            this.OptionTwo.Size = new System.Drawing.Size(150, 46);
            this.OptionTwo.TabIndex = 1;
            this.OptionTwo.Tag = "2";
            this.OptionTwo.Text = "button2";
            this.OptionTwo.UseVisualStyleBackColor = true;
            this.OptionTwo.Click += new System.EventHandler(this.PlayerAnswer);
            // 
            // OptionThree
            // 
            this.OptionThree.Location = new System.Drawing.Point(474, 1173);
            this.OptionThree.Name = "OptionThree";
            this.OptionThree.Size = new System.Drawing.Size(150, 46);
            this.OptionThree.TabIndex = 2;
            this.OptionThree.Tag = "3";
            this.OptionThree.Text = "button3";
            this.OptionThree.UseVisualStyleBackColor = true;
            this.OptionThree.Click += new System.EventHandler(this.PlayerAnswer);
            // 
            // OptionFour
            // 
            this.OptionFour.Location = new System.Drawing.Point(917, 1173);
            this.OptionFour.Name = "OptionFour";
            this.OptionFour.Size = new System.Drawing.Size(150, 46);
            this.OptionFour.TabIndex = 3;
            this.OptionFour.Tag = "4";
            this.OptionFour.Text = "button4";
            this.OptionFour.UseVisualStyleBackColor = true;
            this.OptionFour.Click += new System.EventHandler(this.PlayerAnswer);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuizzApp.Properties.Resources.Doom;
            this.pictureBox1.Location = new System.Drawing.Point(39, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1760, 716);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // QuestionDisplay
            // 
            this.QuestionDisplay.Location = new System.Drawing.Point(114, 786);
            this.QuestionDisplay.Name = "QuestionDisplay";
            this.QuestionDisplay.Size = new System.Drawing.Size(1091, 49);
            this.QuestionDisplay.TabIndex = 5;
            this.QuestionDisplay.Text = "label1";
            // 
            // InputAnswer
            // 
            this.InputAnswer.Location = new System.Drawing.Point(376, 894);
            this.InputAnswer.Name = "InputAnswer";
            this.InputAnswer.Size = new System.Drawing.Size(813, 39);
            this.InputAnswer.TabIndex = 6;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(686, 949);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(150, 46);
            this.Enter.TabIndex = 7;
            this.Enter.Text = "button1";
            this.Enter.UseVisualStyleBackColor = true;
            // 
            // Video_Game_Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1939, 1357);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.InputAnswer);
            this.Controls.Add(this.QuestionDisplay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OptionFour);
            this.Controls.Add(this.OptionThree);
            this.Controls.Add(this.OptionTwo);
            this.Controls.Add(this.OptionOne);
            this.Name = "Video_Game_Quiz";
            this.Text = "Video_Game_Quiz";
            this.Click += new System.EventHandler(this.PlayerAnswer);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OptionOne;
        private Button OptionTwo;
        private Button OptionThree;
        private Button OptionFour;
        private PictureBox pictureBox1;
        private Label QuestionDisplay;
        private TextBox InputAnswer;
        private Button Enter;
    }
}