using Microsoft.Extensions.DependencyInjection;

namespace Lets__study_.User
{
    static class UserRegistrator
    {
        public static IServiceCollection AddUser(this IServiceCollection services) => services
            .AddTransient<User>()
            ; 
    }
}
