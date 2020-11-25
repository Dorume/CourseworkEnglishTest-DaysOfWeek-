namespace Lets__study_.Forms
{
    partial class ScoreFrm
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
            this.NameOfUserLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameOfUserLabel
            // 
            this.NameOfUserLabel.AutoSize = true;
            this.NameOfUserLabel.Location = new System.Drawing.Point(23, 20);
            this.NameOfUserLabel.Name = "NameOfUserLabel";
            this.NameOfUserLabel.Size = new System.Drawing.Size(53, 13);
            this.NameOfUserLabel.TabIndex = 0;
            this.NameOfUserLabel.Text = "Учасник:";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(23, 48);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(85, 13);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Кількість балів:";
            // 
            // ScoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 81);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.NameOfUserLabel);
            this.Name = "ScoreFrm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "ScoreFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameOfUserLabel;
        private System.Windows.Forms.Label ScoreLabel;
    }
}