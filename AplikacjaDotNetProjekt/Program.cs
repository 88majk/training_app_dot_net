using AplikacjaDotNetProjekt.Database;
using Microsoft.EntityFrameworkCore;
using AplikacjaDotNetProjekt.Database.Services;

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
            CatalogExerciseService service = new CatalogExerciseService(new DBContext());
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
                      
                        string filePath = "C:\\Users\\mikol\\source\\repos\\AplikacjaDotNetProjekt\\addTrainingLibrary\\CatalogExercise.csv";

                        var trainings = CatalogExerciseService.ReadCsv(filePath, ";");

                        // Dodaj dane do bazy danych
                        service.LoadExercisesFromDatabase(trainings);
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