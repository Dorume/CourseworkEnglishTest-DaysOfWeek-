using Lets__study_.Styles.ButtonsS.Interface;
using Lets__study_.Styles.Panels.Interface;
using System;
using System.Windows.Forms;

namespace Lets__study_.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(IPanelStyle panelStyle, IButtonStyle buttonStyle)
        {
            InitializeComponent();
            panelStyle.GetStyle(flowLayoutPanel1);
            panelStyle.GetStyle(panel1);
            CountOfQuestionsNumeric.Value = Properties.Settings.Default.CountOfQuestions;
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
