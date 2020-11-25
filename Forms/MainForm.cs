using System;
using System.Windows.Forms;

namespace Lets__study_.Forms
{
    public partial class MainForm : Form
    {
        private SettingsForm Settings { get; set; }
        private QuestionFrm Question { get; set; }
        public MainForm(SettingsForm child, QuestionFrm questionFrm)
        {
            InitializeComponent();
            Settings = child;
            Settings.MdiParent = this;
            Question = questionFrm;
            Question.MdiParent = this;
        }

        private void HelpManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"Resources/Help.chm");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question.Show();
            BackPanel.Controls.Add(Question);
            BackPanel.Tag = Question;
            Question.TopMost = true;
            Question.BringToFront();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Show();
            BackPanel.Controls.Add(Settings);
            BackPanel.Tag = Settings;
            Settings.TopMost = true;
            Settings.BringToFront();
            Settings.BringToFront();
        }
    }
}
