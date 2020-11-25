using Lets__study_.Services.Interface;
using Lets__study_.Styles.ButtonsS.Interface;
using Lets__study_.Styles.Panels.Interface;
using Lets__study_.Styles.RichTB.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lets__study_.Forms
{
    public partial class QuestionFrm : Form
    {
        private ITestHandler Test { get; set; }
        private IButtonStyle ButtonStyle { get; set; }
        private List<string> QuestionList { get; set; }
        public QuestionFrm(ITestHandler test, IRichTextBoxStyle textBoxStyle, IPanelStyle panelStyle,
            IButtonStyle buttonStyle)
        {
            InitializeComponent();
            Test = test;
            QuestionList = Test.GetQuestions();
            textBoxStyle.GetStyle(QuestionTextBox);
            panelStyle.GetStyle(QuestionsbtnsPanel);
            panelStyle.GetStyle(panel1);
            panelStyle.GetStyle(panel2);
            panelStyle.GetStyle(BottomPanel);
            panelStyle.GetStyle(OkbtnPanel);
            ButtonStyle = buttonStyle;
            CreateBtns();
        }

        private void CreateBtns()
        {
            for(int count = 0; count < Properties.Settings.Default.CountOfQuestions; count++)
            {
                Button btn = new Button()
                {
                    Text = (count+1).ToString(),
                };
                btn.Click += QuestionBtn_Click;
                ButtonStyle.GetStyle(btn);
                QuestionsbtnsPanel.Controls.Add(btn);
            }
            
        }

        private void QuestionBtn_Click(object sender, EventArgs e)
        {
            RefreshQuestionTextBox(QuestionList[int.Parse((sender as Button).Text) - 1]);
        }

        private void RefreshQuestionTextBox(string question)
        {
            QuestionTextBox.Clear();
            QuestionTextBox.Text = question;
        }

        private void QuestionFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
