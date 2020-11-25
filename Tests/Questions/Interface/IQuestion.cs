﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets__study_.Tests.Questions.Interface
{
    interface IQuestion
    {
        string Question { get; set; }
        string Answer { get; set; }
        IQuestion AddQuest(string question, string answer);
    }
}