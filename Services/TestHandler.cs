using Lets__study_.Services.Interface;
using Lets__study_.Tests.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets__study_.Services
{
    class TestHandler : ITestHandler
    {
        private ITest Test { get; set; }
        public TestHandler(ITest test)
        {
            Test = test;
        }
        public int CheckTest(List<string> questions, List<string> answers)
        {
            answers = ClearAnswers(answers).ToList();
            int score = 0;
            List<string> questionList = Test.GetQuestionList();
            List<string> answerList = Test.GetAnswerList();
            foreach()
        }

        private IEnumerable<string> ClearAnswers(List<string> answers) => from answer in answers
                                                                          select answer.ToLower()
                                                                          .Replace(answer[0],
                                                                              char.ToUpper(answer[0]))
                                                                          .Trim(' ', ',', '.');
        //Используй словарь
        public List<string> GetQuestions()
        {
            List<string> questions = new List<string>();

            return questions;
        }
    }
}
