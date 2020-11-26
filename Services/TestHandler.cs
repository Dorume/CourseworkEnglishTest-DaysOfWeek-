using Lets__study_.Services.Interface;
using Lets__study_.Tests.Interface;
using System;
using System.Collections.Generic;

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
            int score = 0;
            int counter = questions.Count - 1;
            foreach (var question in Test.QuestionDictionary)
            {
                string RightAnswer;
                Test.QuestionDictionary.TryGetValue(questions[counter], out RightAnswer);
                if (RightAnswer == answers[counter])
                    score++;
                counter--;
                if (counter < 0)
                    break;
            }
            return score;
        }

        public List<string> GetQuestions()
        {
            List<string> questionList = new List<string>();
            foreach (string key in Test.QuestionDictionary.Keys)
                questionList.Add(key);
            return GetRandomQuestions(questionList);
        }

        private List<string> GetRandomQuestions(List<string> questionList)
        {
            List<string> questionsRandom = new List<string>();
            int count = Properties.Settings.Default.CountOfQuestions;
            Random rnd = new Random();
            while (count > 0)
            {
                questionsRandom.Add(questionList[rnd.Next(questionList.Count)]);
                count--;
            }
            return questionsRandom;
        }
    }
}
