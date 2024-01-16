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
            using (var context = new Database.DBContext())
            {
                if (context.Database.CanConnect())
                {
                    Console.WriteLine("Database already exists.");
                }
                else
                {
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
            Application.Run(new HomePage());
        }
    }
}