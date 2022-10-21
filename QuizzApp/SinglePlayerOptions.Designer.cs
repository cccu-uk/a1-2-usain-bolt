namespace QuizzApp
{
    partial class SinglePlayerOptions
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
            this.VideoGames = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VideoGames
            // 
            this.VideoGames.Location = new System.Drawing.Point(104, 192);
            this.VideoGames.Name = "VideoGames";
            this.VideoGames.Size = new System.Drawing.Size(150, 46);
            this.VideoGames.TabIndex = 0;
            this.VideoGames.Text = "button1";
            this.VideoGames.UseVisualStyleBackColor = true;
            this.VideoGames.Click += new System.EventHandler(this.VideoGames_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(150, 46);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // SinglePlayerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 911);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.VideoGames);
            this.Name = "SinglePlayerOptions";
            this.Text = "SinglePlayerOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private Button VideoGames;
        private Button Back;
    }
}