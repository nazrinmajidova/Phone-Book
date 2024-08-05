using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices;

namespace PhoneBook
{
    internal static class Program
    {
        public static MainForm MainFormInstance { get; private set;}
        public static IConfiguration Configuration { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string connection = Properties.PhoneBook.Default.Connection;

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
            
            ApplicationConfiguration.Initialize();
            MainFormInstance = new MainForm();
            Application.Run(MainFormInstance);
        }
    }
}