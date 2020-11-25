using System;
using System.Windows.Forms;

namespace Lets__study_.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void CountOfQuestions_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.CountOfQuestions = CountOfQuestions.Value;
            Properties.Settings.Default.Save();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
