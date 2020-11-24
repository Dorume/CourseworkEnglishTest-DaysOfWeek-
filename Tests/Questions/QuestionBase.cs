using Lets__study_.Tests.Questions.Interface;

namespace Lets__study_.Tests.Questions
{
    class QuestionBase : IQuestion
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public IQuestion AddQuest(string question, string answer)
        {
            Question = question;
            Answer = answer;
            return this;
        }
    }
}
