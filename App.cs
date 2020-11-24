using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Lets__study_
{
    class App
    {
        private static IHost _Host;

        public static IHost Host => _Host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        public static IServiceProvider Services => Host.Services;

        internal static void ConfigureService(HostBuilderContext host, IServiceCollection services)
        {

        }

        internal static async void OnStartup()
        {
            var host = Host;
            await host.StartAsync();
        }

        internal static async void OnExit(object sender, EventArgs e)
        {
            using var host = Host;
            await host.StopAsync();
        }
    }
}
