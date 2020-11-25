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

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void CountOfQuestionsNumeric_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CountOfQuestions = (int)CountOfQuestionsNumeric.Value;
            Properties.Settings.Default.Save();
        }
    }
}
