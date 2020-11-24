using Lets__study_.Forms;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace Lets__study_
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            App.OnStartup();
            Application.ApplicationExit += App.OnExit;
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureServices(App.ConfigureService)
            ;



    }
}
