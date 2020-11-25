using Lets__study_.Tests.Questions.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Lets__study_.Tests.Questions
{
    static class QuestionsRegistrator
    {
        public static IServiceCollection AddQuestions(this IServiceCollection services) => services
            .AddTransient<IQuestion, QuestionBase>()
            ;
    }
}
