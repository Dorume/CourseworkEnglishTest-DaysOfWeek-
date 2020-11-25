using System;
using System.Windows.Forms;

namespace Lets__study_.Forms
{
    public partial class MainForm : Form
    {
        private SettingsForm Settings { get; set; }
        public MainForm(SettingsForm child)
        {
            InitializeComponent();
            Settings = child;
            Settings.MdiParent = this;
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

        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Show();
        }
    }
}
