namespace Lets__study_.Forms
{
    partial class QuestionFrm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LevelsBtn = new System.Windows.Forms.Panel();
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.AnswerPanel = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.OkbtnPanel = new System.Windows.Forms.Panel();
            this.AnswerBtn = new System.Windows.Forms.Button();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.FinishTestBtn = new System.Windows.Forms.Button();
            this.QuestionPanel.SuspendLayout();
            this.AnswerPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.OkbtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(384, 172);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // LevelsBtn
            // 
            this.LevelsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LevelsBtn.Location = new System.Drawing.Point(0, 0);
            this.LevelsBtn.Name = "LevelsBtn";
            this.LevelsBtn.Size = new System.Drawing.Size(384, 36);
            this.LevelsBtn.TabIndex = 3;
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.Controls.Add(this.AnswerPanel);
            this.QuestionPanel.Controls.Add(this.richTextBox1);
            this.QuestionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionPanel.Location = new System.Drawing.Point(0, 36);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(384, 275);
            this.QuestionPanel.TabIndex = 5;
            // 
            // AnswerPanel
            // 
            this.AnswerPanel.Controls.Add(this.richTextBox2);
            this.AnswerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswerPanel.Location = new System.Drawing.Point(0, 172);
            this.AnswerPanel.Name = "AnswerPanel";
            this.AnswerPanel.Padding = new System.Windows.Forms.Padding(100, 30, 100, 30);
            this.AnswerPanel.Size = new System.Drawing.Size(384, 103);
            this.AnswerPanel.TabIndex = 3;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(100, 30);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(184, 43);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.OkbtnPanel);
            this.BottomPanel.Controls.Add(this.PrevBtn);
            this.BottomPanel.Controls.Add(this.NextBtn);
            this.BottomPanel.Controls.Add(this.FinishTestBtn);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 311);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Padding = new System.Windows.Forms.Padding(5);
            this.BottomPanel.Size = new System.Drawing.Size(384, 100);
            this.BottomPanel.TabIndex = 4;
            // 
            // OkbtnPanel
            // 
            this.OkbtnPanel.Controls.Add(this.AnswerBtn);
            this.OkbtnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OkbtnPanel.Location = new System.Drawing.Point(80, 5);
            this.OkbtnPanel.Name = "OkbtnPanel";
            this.OkbtnPanel.Padding = new System.Windows.Forms.Padding(20);
            this.OkbtnPanel.Size = new System.Drawing.Size(149, 90);
            this.OkbtnPanel.TabIndex = 3;
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswerBtn.Location = new System.Drawing.Point(20, 20);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(109, 50);
            this.AnswerBtn.TabIndex = 0;
            this.AnswerBtn.Text = "Відповісти";
            this.AnswerBtn.UseVisualStyleBackColor = true;
            // 
            // PrevBtn
            // 
            this.PrevBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.PrevBtn.Location = new System.Drawing.Point(229, 5);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(75, 90);
            this.PrevBtn.TabIndex = 2;
            this.PrevBtn.Text = "Назад";
            this.PrevBtn.UseVisualStyleBackColor = true;
            // 
            // NextBtn
            // 
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextBtn.Location = new System.Drawing.Point(304, 5);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 90);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = "Вперед";
            this.NextBtn.UseVisualStyleBackColor = true;
            // 
            // FinishTestBtn
            // 
            this.FinishTestBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.FinishTestBtn.Location = new System.Drawing.Point(5, 5);
            this.FinishTestBtn.Name = "FinishTestBtn";
            this.FinishTestBtn.Size = new System.Drawing.Size(75, 90);
            this.FinishTestBtn.TabIndex = 0;
            this.FinishTestBtn.Text = "Завершити тест";
            this.FinishTestBtn.UseVisualStyleBackColor = true;
            // 
            // QuestionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.LevelsBtn);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "QuestionFrm";
            this.Text = "QuestionFrm";
            this.QuestionPanel.ResumeLayout(false);
            this.AnswerPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.OkbtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel LevelsBtn;
        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel OkbtnPanel;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button FinishTestBtn;
        private System.Windows.Forms.Button AnswerBtn;
        private System.Windows.Forms.Panel AnswerPanel;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}