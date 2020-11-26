using Lets__study_.Services.Interface;
using Lets__study_.Styles.ButtonsS.Interface;
using Lets__study_.Styles.Panels.Interface;
using Lets__study_.Styles.RichTB.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lets__study_.Forms
{
    public partial class QuestionFrm : Form
    {
        private ITestHandler Test { get; set; }
        private IButtonStyle ButtonStyle { get; set; }
        private List<string> QuestionList { get; set; }
        private List<string> AnswerList { get; set; }
        private List<bool> CheckedList { get; set; }
        private Button _CurrentButton = new Button();
        private Button CurrentQuestion
        {
            get => _CurrentButton;
            set
            {
                ButtonStyle.GetStyle(_CurrentButton);
                _CurrentButton = value;
                Counter = int.Parse(_CurrentButton.Name);
            }
        }
        private int Counter;
        public int Score;

        public QuestionFrm(ITestHandler test, IRichTextBoxStyle textBoxStyle, IPanelStyle panelStyle,
            IButtonStyle buttonStyle)
        {
            InitializeComponent();
            Test = test;
            QuestionList = Test.GetQuestions();

            CurrentQuestion.Name = "1";

            AnswerList = new List<string>(QuestionList.Count);
            CheckedList = new List<bool>(QuestionList.Count);
            FillLists();

            textBoxStyle.GetStyle(QuestionTextBox);
            panelStyle.GetStyle(QuestionsbtnsPanel);
            panelStyle.GetStyle(panel1);
            panelStyle.GetStyle(panel2);
            panelStyle.GetStyle(BottomPanel);
            panelStyle.GetStyle(OkbtnPanel);
            ButtonStyle = buttonStyle;

            ButtonStyle.GetStyle(FinishTestBtn);
            ButtonStyle.GetStyle(NextBtn);
            ButtonStyle.GetStyle(PrevBtn);
            ButtonStyle.GetStyle(AnswerBtn);

            CreateBtns();
            RefreshQuestionTextBox(QuestionList[Counter]);

        }

        private void FillLists()
        {
            for (int count = 0; count < QuestionList.Count; count++)
            {
                AnswerList.Add("");
                CheckedList.Add(false);
            }

        }

        private void CreateBtns()
        {
            for (int count = 0; count < Properties.Settings.Default.CountOfQuestions; count++)
            {
                Button btn = new Button()
                {
                    Text = (count + 1).ToString(),
                    Name = count.ToString(),
                };
                btn.Click += QuestionBtn_Click;
                ButtonStyle.GetStyle(btn);
                QuestionsbtnsPanel.Controls.Add(btn);
                if (count == 0)
                    CurrentQuestion = btn;
            }

        }

        private void QuestionBtn_Click(object sender, EventArgs e)
        {
            CurrentQuestion = (sender as Button);
            RefreshQuestionTextBox(QuestionList[Counter]);
        }

        private void RefreshQuestionTextBox(string question)
        {
            QuestionTextBox.Clear();
            QuestionTextBox.Text = question;
            CurrentQuestion.BackColor = Color.Orange;
            richTextBox2.Text = AnswerList[Counter];
            richTextBox2.ReadOnly = CheckedList[Counter];
            DisplayCheckedLabel.Visible = CheckedList[Counter];
        }

        private void QuestionFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            AnswerList[Counter] = richTextBox2.Text;
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            CheckedList[Counter] = true;
            richTextBox2.ReadOnly = CheckedList[Counter];
            DisplayCheckedLabel.Visible = CheckedList[Counter];
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            string currentNumber = (Counter + 1).ToString();
            foreach (Button button in QuestionsbtnsPanel.Controls)
            {
                if (currentNumber == button.Name)
                {
                    CurrentQuestion = button;
                    break;
                }
            }
            RefreshQuestionTextBox(QuestionList[Counter]);
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            string currentNumber = (Counter - 1).ToString();
            foreach (Button button in QuestionsbtnsPanel.Controls)
            {
                if (currentNumber == button.Name)
                {
                    CurrentQuestion = button;
                    break;
                }
            }
            RefreshQuestionTextBox(QuestionList[Counter]);
        }

        private void FinishTestBtn_Click(object sender, EventArgs e)
        {
            Score = Test.CheckTest(QuestionList, AnswerList);
            Close();
        }
    }
}
