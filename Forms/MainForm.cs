using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace Lets__study_.Forms
{
    public partial class MainForm : Form
    {
        private SettingsForm Settings { get; set; }

        public MainForm(SettingsForm settings)
        {
            InitializeComponent();
            Settings = settings;
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
            UserFrm userFrm = App.Host.Services.GetRequiredService<UserFrm>();
            userFrm.MdiParent = this;
            userFrm.Show();
            BackPanel.Controls.Add(userFrm);
            BackPanel.Tag = userFrm;
            userFrm.TopMost = true;
            userFrm.BringToFront();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Show();
            BackPanel.Controls.Add(Settings);
            BackPanel.Tag = Settings;
            Settings.TopMost = true;
            Settings.BringToFront();
        }
    }
}
