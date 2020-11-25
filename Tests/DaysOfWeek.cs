using Lets__study_.Tests.Interface;
using Lets__study_.Tests.Questions.Interface;
using System.Collections.Generic;

namespace Lets__study_.Tests
{
    class DaysOfWeek : ITest
    {
        private List<IQuestion> Questions { get; set; } = new List<IQuestion>();

        public DaysOfWeek(IQuestion question)
        {
            Questions.Add(question.AddQuest("Monday", "Понеділок"));
            Questions.Add(question.AddQuest("Tuesday", "Вівтор"));
            Questions.Add(question.AddQuest("Wednesday", "Середа"));
            Questions.Add(question.AddQuest("Thursday", "Четверг"));
            Questions.Add(question.AddQuest("Friday", "Пятниця"));
            Questions.Add(question.AddQuest("Saturday", "Субота"));
            Questions.Add(question.AddQuest("Sunday", "Неділя"));
        }

        public List<string> GetQuestionList()
        {
            List<string> questionList = new List<string>();
            foreach (IQuestion question in Questions)
                questionList.Add(question.Question);
            return questionList;
        }

        public List<string> GetAnswerList()
        {
            List<string> answerList = new List<string>();
            foreach (IQuestion answer in Questions)
                answerList.Add(answer.Answer);
            return answerList;
        }
    }
}
