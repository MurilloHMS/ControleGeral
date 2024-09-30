using KhoraControl.Setup.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace KhoraControl
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                KhoraContext context = new KhoraContext();
                context.Database.EnsureCreated();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Frm_MainWindow());

            }
        }
    }
}