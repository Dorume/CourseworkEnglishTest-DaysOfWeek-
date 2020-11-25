namespace Lets__study_.Forms
{
    partial class SettingsForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CountOfQuestions = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.CountOfQuestions);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(259, 248);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість запитань";
            // 
            // CountOfQuestions
            // 
            this.CountOfQuestions.Location = new System.Drawing.Point(112, 3);
            this.CountOfQuestions.Maximum = 15;
            this.CountOfQuestions.Minimum = 5;
            this.CountOfQuestions.Name = "CountOfQuestions";
            this.CountOfQuestions.Size = new System.Drawing.Size(133, 45);
            this.CountOfQuestions.TabIndex = 1;
            this.CountOfQuestions.Value = global::Lets__study_.Properties.Settings.Default.CountOfQuestions;
            this.CountOfQuestions.Scroll += new System.EventHandler(this.CountOfQuestions_Scroll);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 288);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = global::Lets__study_.Properties.Resources.SettingsFormIcon;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "SettingsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar CountOfQuestions;
    }
}