using Microsoft.Extensions.DependencyInjection;

namespace Lets__study_.Forms
{
    static class FormRegistrator
    {
        public static IServiceCollection AddForms(this IServiceCollection services) => services
            .AddSingleton<MainForm>()
            .AddTransient<QuestionFrm>()
            .AddScoped<SettingsForm>()
            ;
    }
}
