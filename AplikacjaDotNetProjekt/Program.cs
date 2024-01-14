using Microsoft.EntityFrameworkCore;

namespace AplikacjaDotNetProjekt
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new Database.DBContext())
            {
                context.Database.Migrate();

            }
            ApplicationConfiguration.Initialize();
            Application.Run(new HomePage());
        }
    }
}