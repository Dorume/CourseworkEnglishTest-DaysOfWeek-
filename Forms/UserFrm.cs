using Lets__study_.Styles.ButtonsS.Interface;
using Lets__study_.Styles.Panels.Interface;
using Lets__study_.User.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace Lets__study_.Forms
{
    public partial class UserFrm : Form
    {
        private QuestionFrm QuestionFrm { get; set; }
        private ScoreFrm ScoreFrm { get; set; }
        private IUser User { get; set; }

        public UserFrm(IPanelStyle panelStyle, IButtonStyle buttonStyle, IUser user,
            QuestionFrm questionFrm, ScoreFrm scoreFrm)
        {
            InitializeComponent();
            panelStyle.GetStyle(MainPanel);
            panelStyle.GetStyle(flowLayoutPanel1);
            buttonStyle.GetStyle(StartBtn);
            QuestionFrm = questionFrm;
            ScoreFrm = scoreFrm;
            User = user;


            ScoreFrm.MdiParent = this.MdiParent;

            QuestionFrm.FormClosing += QuestionFrm_FormClosing;
        }

        private void NameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            User.Name = NameTextBox.Text;
        }
        private void SurnameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            User.Surname = SurnameTextBox.Text;
        }
        private void StartBtn_Click(object sender, System.EventArgs e)
        {
            Hide();
            DiplayOnMainForm(QuestionFrm);
        }

        private void QuestionFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisplayScoreForm(QuestionFrm.Score);
        }

        private void DisplayScoreForm(int score)
        {
            ScoreFrm.Score = score;
            ScoreFrm.User = User;
            DiplayOnMainForm(ScoreFrm);
            this.Close();
        }

        private void DiplayOnMainForm(Form form)
        {
            MainForm mainForm = App.Host.Services.GetRequiredService<MainForm>();
            form.MdiParent = mainForm;
            mainForm.BackPanel.Controls.Add(form);
            mainForm.BackPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
