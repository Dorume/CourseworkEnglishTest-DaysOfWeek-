using Lets__study_.Styles.ButtonsS.Interface;
using Lets__study_.Styles.Panels.Interface;
using Lets__study_.User.Interface;
using System.Windows.Forms;

namespace Lets__study_.Forms
{
    public partial class UserFrm : Form
    {
        private QuestionFrm QuestionFrm { get; set; }
        private ScoreFrm ScoreFrm { get; set; }
        private IUser User { get; set; }

        public int Score
        {
            get => Score;
            set
            {
                Score = value;
                DisplayScoreForm();
            }
        }

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
            QuestionFrm.MdiParent = MdiParent;
            QuestionFrm.Show();
        }

        private void DisplayScoreForm()
        {
            ScoreFrm.MdiParent = MdiParent;
            ScoreFrm.Score = Score;
            ScoreFrm.User = User;
            ScoreFrm.Show();
            this.Close();
        }
    }
}
