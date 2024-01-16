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
            try
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
                Login login = new Login();
                Application.Run(login);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wyst¹pi³ b³¹d podczas migracji bazy danych: {ex.Message}");
            }
        }
    }
}