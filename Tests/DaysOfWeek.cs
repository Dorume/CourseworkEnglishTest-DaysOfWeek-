using Lets__study_.Tests.Interface;
using Lets__study_.Tests.Questions;
using Lets__study_.Tests.Questions.Interface;
using System.Collections.Generic;

namespace Lets__study_.Tests
{
    class DaysOfWeek : ITest
    {
        public IList<IQuestion> Questions { get; set; } = new List<IQuestion>();

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
    }
}
