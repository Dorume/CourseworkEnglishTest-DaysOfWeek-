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
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.QuestionTextBox = new System.Windows.Forms.RichTextBox();
            this.QuestionsbtnsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.OkbtnPanel = new System.Windows.Forms.Panel();
            this.AnswerBtn = new System.Windows.Forms.Button();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.FinishTestBtn = new System.Windows.Forms.Button();
            this.DisplayCheckedLabel = new System.Windows.Forms.Label();
            this.QuestionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.OkbtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.Controls.Add(this.panel1);
            this.QuestionPanel.Controls.Add(this.QuestionsbtnsPanel);
            this.QuestionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionPanel.Location = new System.Drawing.Point(0, 0);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(384, 311);
            this.QuestionPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.QuestionTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 255);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DisplayCheckedLabel);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(50);
            this.panel2.Size = new System.Drawing.Size(384, 140);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(50, 50);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(284, 40);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestionTextBox.Location = new System.Drawing.Point(0, 0);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.ReadOnly = true;
            this.QuestionTextBox.Size = new System.Drawing.Size(384, 115);
            this.QuestionTextBox.TabIndex = 0;
            this.QuestionTextBox.Text = "";
            // 
            // QuestionsbtnsPanel
            // 
            this.QuestionsbtnsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestionsbtnsPanel.Location = new System.Drawing.Point(0, 0);
            this.QuestionsbtnsPanel.Name = "QuestionsbtnsPanel";
            this.QuestionsbtnsPanel.Size = new System.Drawing.Size(384, 56);
            this.QuestionsbtnsPanel.TabIndex = 0;
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
            this.BottomPanel.Padding = new System.Windows.Forms.Padding(15);
            this.BottomPanel.Size = new System.Drawing.Size(384, 100);
            this.BottomPanel.TabIndex = 4;
            // 
            // OkbtnPanel
            // 
            this.OkbtnPanel.Controls.Add(this.AnswerBtn);
            this.OkbtnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OkbtnPanel.Location = new System.Drawing.Point(90, 15);
            this.OkbtnPanel.Name = "OkbtnPanel";
            this.OkbtnPanel.Padding = new System.Windows.Forms.Padding(20);
            this.OkbtnPanel.Size = new System.Drawing.Size(129, 70);
            this.OkbtnPanel.TabIndex = 3;
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswerBtn.Location = new System.Drawing.Point(20, 20);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(89, 30);
            this.AnswerBtn.TabIndex = 0;
            this.AnswerBtn.Text = "Відповісти";
            this.AnswerBtn.UseVisualStyleBackColor = true;
            this.AnswerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.PrevBtn.Location = new System.Drawing.Point(219, 15);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(75, 70);
            this.PrevBtn.TabIndex = 2;
            this.PrevBtn.Text = "Назад";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextBtn.Location = new System.Drawing.Point(294, 15);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 70);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = "Вперед";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // FinishTestBtn
            // 
            this.FinishTestBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.FinishTestBtn.Location = new System.Drawing.Point(15, 15);
            this.FinishTestBtn.Name = "FinishTestBtn";
            this.FinishTestBtn.Size = new System.Drawing.Size(75, 70);
            this.FinishTestBtn.TabIndex = 0;
            this.FinishTestBtn.Text = "Завершити тест";
            this.FinishTestBtn.UseVisualStyleBackColor = true;
            this.FinishTestBtn.Click += new System.EventHandler(this.FinishTestBtn_Click);
            // 
            // DisplayCheckedLabel
            // 
            this.DisplayCheckedLabel.AutoSize = true;
            this.DisplayCheckedLabel.Location = new System.Drawing.Point(3, 3);
            this.DisplayCheckedLabel.Name = "DisplayCheckedLabel";
            this.DisplayCheckedLabel.Size = new System.Drawing.Size(119, 13);
            this.DisplayCheckedLabel.TabIndex = 1;
            this.DisplayCheckedLabel.Text = "Відповідь зарахована!";
            this.DisplayCheckedLabel.Visible = false;
            // 
            // QuestionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.BottomPanel);
            this.Icon = global::Lets__study_.Properties.Resources.QuestionFormIcon;
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "QuestionFrm";
            this.Text = "Test time!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionFrm_FormClosing);
            this.QuestionPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.OkbtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel OkbtnPanel;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button FinishTestBtn;
        private System.Windows.Forms.Button AnswerBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox QuestionTextBox;
        private System.Windows.Forms.FlowLayoutPanel QuestionsbtnsPanel;
        private System.Windows.Forms.Label DisplayCheckedLabel;
    }
}