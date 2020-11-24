using Lets__study_.Tests.Questions;
using Lets__study_.Tests.Questions.Interface;
using System.Collections.Generic;

namespace Lets__study_.Tests.Interface
{
    interface ITest
    {
        IList<IQuestion> Questions { get; set; }
    }
}
