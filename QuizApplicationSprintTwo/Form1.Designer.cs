namespace QuizApplicationSprintTwo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SinglePlayerOptions = new QuizApplicationSprintTwo.MyButton();
            this.MultiplayerOptions = new QuizApplicationSprintTwo.MyButton();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SinglePlayerOptions
            // 
            this.SinglePlayerOptions.BackColor = System.Drawing.Color.Crimson;
            this.SinglePlayerOptions.FlatAppearance.BorderSize = 0;
            this.SinglePlayerOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SinglePlayerOptions.ForeColor = System.Drawing.Color.White;
            this.SinglePlayerOptions.Location = new System.Drawing.Point(162, 762);
            this.SinglePlayerOptions.Name = "SinglePlayerOptions";
            this.SinglePlayerOptions.Size = new System.Drawing.Size(300, 80);
            this.SinglePlayerOptions.TabIndex = 0;
            this.SinglePlayerOptions.Text = "One Player";
            this.SinglePlayerOptions.UseVisualStyleBackColor = false;
            this.SinglePlayerOptions.Click += new System.EventHandler(this.SinglePlayerOptions_Click);
            // 
            // MultiplayerOptions
            // 
            this.MultiplayerOptions.BackColor = System.Drawing.Color.Crimson;
            this.MultiplayerOptions.FlatAppearance.BorderSize = 0;
            this.MultiplayerOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplayerOptions.ForeColor = System.Drawing.Color.White;
            this.MultiplayerOptions.Location = new System.Drawing.Point(914, 762);
            this.MultiplayerOptions.Name = "MultiplayerOptions";
            this.MultiplayerOptions.Size = new System.Drawing.Size(300, 80);
            this.MultiplayerOptions.TabIndex = 1;
            this.MultiplayerOptions.Text = "Multiplayer";
            this.MultiplayerOptions.UseVisualStyleBackColor = false;
            this.MultiplayerOptions.Click += new System.EventHandler(this.MultiplayerOptions_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(591, 507);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(179, 32);
            this.Title.TabIndex = 2;
            this.Title.Text = "The Quiz Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1457, 1571);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MultiplayerOptions);
            this.Controls.Add(this.SinglePlayerOptions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton SinglePlayerOptions;
        private MyButton MultiplayerOptions;
        private Label Title;
    }
}