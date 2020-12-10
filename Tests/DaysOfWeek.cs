using Lets__study_.Tests.Interface;
using System.Collections.Generic;

namespace Lets__study_.Tests
{
    class DaysOfWeek : ITest
    {
        public Dictionary<string, string> QuestionDictionary { get; set; } = new Dictionary<string, string>()
        {
            {"Monday", "понеділок" },
            {"Tuesday", "вівторок" },
            {"Wednesday", "середа" },
            {"Thursday", "четвер" },
            {"Friday", "пятниця" },
            {"Saturday", "субота" },
            {"Sunday", "неділя" },
        };
    }
}
