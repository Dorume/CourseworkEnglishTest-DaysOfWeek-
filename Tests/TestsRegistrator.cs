﻿using Microsoft.Extensions.DependencyInjection;

namespace Lets__study_.Tests
{
    static class TestsRegistrator
    {
        public static IServiceCollection AddTest(this IServiceCollection services) => services
            .AddTransient<DaysOfWeek>()
            ;
    }
}
