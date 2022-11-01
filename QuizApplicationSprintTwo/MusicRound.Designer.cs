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
            this.SuspendLayout();
            // 
            // beginMusic
            // 
            this.beginMusic.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.beginMusic.FlatAppearance.BorderSize = 0;
            this.beginMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginMusic.ForeColor = System.Drawing.Color.White;
            this.beginMusic.Location = new System.Drawing.Point(299, 285);
            this.beginMusic.Name = "beginMusic";
            this.beginMusic.Size = new System.Drawing.Size(150, 40);
            this.beginMusic.TabIndex = 0;
            this.beginMusic.Text = "Start!";
            this.beginMusic.UseVisualStyleBackColor = false;
            // 
            // MusicRound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.beginMusic);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "MusicRound";
            this.Text = "MusicRound";
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton beginMusic;
    }
}