using System.Collections.Generic;

namespace Lets__study_.Services.Interface
{
    interface ITestHandler
    {
        List<string> GetQuestions();
        int CheckTest(List<string> questions,List<string> answers);
    }
}
