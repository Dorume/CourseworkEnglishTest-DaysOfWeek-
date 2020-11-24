using Lets__study_.Tests.Interface;
using Lets__study_.Tests.Questions;
using System.Collections.Generic;

namespace Lets__study_.Tests
{
    class DaysOfWeek : ITest
    {
        public IList<QuestionBase> Questions { get; set; } = new List<QuestionBase>()
        {
            new QuestionBase { Question = "Monday", Answer = "Понеділок"},
            new QuestionBase { Question = "Tuesday", Answer = "Вівторк"},
            new QuestionBase { Question = "Wednesday", Answer = "Середа"},
            new QuestionBase { Question = "Thursday", Answer = "Четверг"},
            new QuestionBase { Question = "Friday", Answer = "Пятниця"},
            new QuestionBase { Question = "Saturday", Answer = "Субота"},
            new QuestionBase { Question = "Sunday", Answer = "Неділя"}
        };
    }
}
