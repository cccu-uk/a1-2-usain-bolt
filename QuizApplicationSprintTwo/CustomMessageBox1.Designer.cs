namespace QuizApplicationSprintTwo
{
    partial class CustomMessageBox1
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
            this.OptOne = new QuizApplicationSprintTwo.MyButton();
            this.OptTwo = new QuizApplicationSprintTwo.MyButton();
            this.OptThree = new QuizApplicationSprintTwo.MyButton();
            this.MessageDisp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OptOne
            // 
            this.OptOne.BackColor = System.Drawing.Color.Crimson;
            this.OptOne.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OptOne.FlatAppearance.BorderSize = 0;
            this.OptOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptOne.ForeColor = System.Drawing.Color.White;
            this.OptOne.Location = new System.Drawing.Point(160, 228);
            this.OptOne.Name = "OptOne";
            this.OptOne.Size = new System.Drawing.Size(220, 74);
            this.OptOne.TabIndex = 0;
            this.OptOne.Text = "10";
            this.OptOne.UseVisualStyleBackColor = false;
            // 
            // OptTwo
            // 
            this.OptTwo.BackColor = System.Drawing.Color.Crimson;
            this.OptTwo.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.OptTwo.FlatAppearance.BorderSize = 0;
            this.OptTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptTwo.ForeColor = System.Drawing.Color.White;
            this.OptTwo.Location = new System.Drawing.Point(445, 228);
            this.OptTwo.Name = "OptTwo";
            this.OptTwo.Size = new System.Drawing.Size(220, 74);
            this.OptTwo.TabIndex = 1;
            this.OptTwo.Text = "15";
            this.OptTwo.UseVisualStyleBackColor = false;
            // 
            // OptThree
            // 
            this.OptThree.BackColor = System.Drawing.Color.Crimson;
            this.OptThree.DialogResult = System.Windows.Forms.DialogResult.Continue;
            this.OptThree.FlatAppearance.BorderSize = 0;
            this.OptThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptThree.ForeColor = System.Drawing.Color.White;
            this.OptThree.Location = new System.Drawing.Point(733, 228);
            this.OptThree.Name = "OptThree";
            this.OptThree.Size = new System.Drawing.Size(220, 74);
            this.OptThree.TabIndex = 2;
            this.OptThree.Text = "20";
            this.OptThree.UseVisualStyleBackColor = false;
            // 
            // MessageDisp
            // 
            this.MessageDisp.AutoSize = true;
            this.MessageDisp.Location = new System.Drawing.Point(336, 87);
            this.MessageDisp.Name = "MessageDisp";
            this.MessageDisp.Size = new System.Drawing.Size(108, 32);
            this.MessageDisp.TabIndex = 3;
            this.MessageDisp.Text = "Message";
            // 
            // CustomMessageBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1134, 325);
            this.Controls.Add(this.MessageDisp);
            this.Controls.Add(this.OptThree);
            this.Controls.Add(this.OptTwo);
            this.Controls.Add(this.OptOne);
            this.Name = "CustomMessageBox1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton OptOne;
        private MyButton OptTwo;
        private MyButton OptThree;
        private Label MessageDisp;
    }
}