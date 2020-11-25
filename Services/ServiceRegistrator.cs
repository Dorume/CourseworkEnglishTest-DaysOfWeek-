using Lets__study_.Services.Interface;
using Microsoft.Extensions.DependencyInjection;
namespace Lets__study_.Services
{
    static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<ITestHandler, TestHandler>()
            ;
    }
}
