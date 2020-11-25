using Lets__study_.Styles.ButtonsS.Interface;
using Lets__study_.Styles.Panels.Interface;
using Lets__study_.User.Interface;
using System.Windows.Forms;

namespace Lets__study_.Forms
{
    public partial class ScoreFrm : Form
    {
        public int Score { get; set; }
        public IUser User { get; set; }
        public ScoreFrm(IPanelStyle panelStyle, IButtonStyle buttonStyle)
        {
            InitializeComponent();
            panelStyle.GetStyle(MainPanel);
            panelStyle.GetStyle(flowLayoutPanel1);
            buttonStyle.GetStyle(CloseBtn);

            UserLabel.Text = User.Surname + " " + User.Name;
            ScoreLabel.Text = Score.ToString();
        }



    }
}
