using Lets__study_.Services.Interface;
using Lets__study_.Styles.RichTB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lets__study_.Forms
{
    public partial class QuestionFrm : Form
    {
        private ITestHandler Test { get; set; }
       // private IRichTextBoxStyle TextBoxStyle { get; set; }
        private List<string> QuestionList { get; set; }
        public QuestionFrm(ITestHandler test, IRichTextBoxStyle textBoxStyle)
        {
            InitializeComponent();
            Test = test;
            QuestionList = Test.GetQuestions();
            //TextBoxStyle = textBoxStyle;
            textBoxStyle.GetStyle(QuestionTextBox);
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
