namespace QuizApplicationSprintTwo
{
    partial class MusicRound
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
            this.beginMusic = new QuizApplicationSprintTwo.MyButton();
            this.myButton1 = new QuizApplicationSprintTwo.MyButton();
            this.myButton2 = new QuizApplicationSprintTwo.MyButton();
            this.myButton3 = new QuizApplicationSprintTwo.MyButton();
            this.SuspendLayout();
            // 
            // beginMusic
            // 
            this.beginMusic.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.beginMusic.FlatAppearance.BorderSize = 0;
            this.beginMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginMusic.ForeColor = System.Drawing.Color.White;
            this.beginMusic.Location = new System.Drawing.Point(114, 257);
            this.beginMusic.Name = "beginMusic";
            this.beginMusic.Size = new System.Drawing.Size(150, 40);
            this.beginMusic.TabIndex = 0;
            this.beginMusic.Text = "Answer one";
            this.beginMusic.UseVisualStyleBackColor = false;
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.ForeColor = System.Drawing.Color.White;
            this.myButton1.Location = new System.Drawing.Point(484, 257);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(150, 40);
            this.myButton1.TabIndex = 1;
            this.myButton1.Text = "myButton1";
            this.myButton1.UseVisualStyleBackColor = false;
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.myButton2.FlatAppearance.BorderSize = 0;
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.ForeColor = System.Drawing.Color.White;
            this.myButton2.Location = new System.Drawing.Point(484, 333);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(150, 40);
            this.myButton2.TabIndex = 2;
            this.myButton2.Text = "myButton2";
            this.myButton2.UseVisualStyleBackColor = false;
            // 
            // myButton3
            // 
            this.myButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.myButton3.FlatAppearance.BorderSize = 0;
            this.myButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton3.ForeColor = System.Drawing.Color.White;
            this.myButton3.Location = new System.Drawing.Point(114, 333);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(150, 40);
            this.myButton3.TabIndex = 3;
            this.myButton3.Text = "myButton3";
            this.myButton3.UseVisualStyleBackColor = false;
            // 
            // MusicRound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.beginMusic);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "MusicRound";
            this.Text = "MusicRound";
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton beginMusic;
        private MyButton myButton1;
        private MyButton myButton2;
        private MyButton myButton3;
    }
}