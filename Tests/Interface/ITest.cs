﻿using Lets__study_.Tests.Questions;
using System.Collections.Generic;

namespace Lets__study_.Tests.Interface
{
    interface ITest
    {
        IList<QuestionBase> Questions { get; set; }
    }
}