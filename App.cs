using Lets__study_.Forms;
using Lets__study_.Services;
using Lets__study_.Styles;
using Lets__study_.Tests;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace Lets__study_
{
    class App
    {
        private static IHost _Host;

        public static IHost Host => _Host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        public static IServiceProvider Services => Host.Services;

        internal static void ConfigureService(HostBuilderContext host, IServiceCollection services) => services
            .AddForms()
            .AddTest()
            .AddServices()
            .AddStyles()
            ;
        internal static async void OnStartup()
        {
            var host = Host;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Services.GetRequiredService<MainForm>());
            await host.StartAsync();
        }

        internal static async void OnExit(object sender, EventArgs e)
        {
            using var host = Host;
            await host.StopAsync();
        }
    }
}
