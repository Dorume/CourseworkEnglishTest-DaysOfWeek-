using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets__study_.Tests.Questions
{
    static class QuestionsRegistrator
    {
        public static IServiceCollection AddQuestions(this IServiceCollection services) => services
            .AddTransient<QuestionBase>()
            ;
    }
}
