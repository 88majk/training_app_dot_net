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
                if (context.Database.CanConnect())
                {
                    // Baza danych istnieje, nie wykonuj tworzenia
                    Console.WriteLine("Database already exists.");
                }
                else
                {
                    // Baza danych nie istnieje, wykonaj tworzenie
                    Console.WriteLine("Creating database...");
                    context.Database.EnsureCreated();
                    Console.WriteLine("Database created.");
                }
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new HomePage());
        }
    }
}