using Lets__study_.Tests.Questions.Interface;
using System.Collections.Generic;

namespace Lets__study_.Tests.Questions
{
    class QuestionBase : IQuestion
    {
        public Dictionary<string, string> QuestionList { get; set; }

        public IQuestion AddQuest(string question, string answer)
        {
            Question = question;
            Answer = answer;
            return this;
        }
    }
}
