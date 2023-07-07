using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameworkUI
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new Form1());
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            ServiceProvider = services.BuildServiceProvider();
        }

        public static T GetService<T>() where T : class
        {
            return (T)ServiceProvider.GetService(typeof(T));
        }
    }
}
