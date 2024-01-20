using AplikacjaDotNetProjekt.Database.Models;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDotNetProjekt.Database.Services
{
    public class CatalogExerciseService
    {
        private readonly DBContext _dbContext;

        public CatalogExerciseService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddExerciseToDatabase(CatalogExercise exercise)
        {
            try
            {
                _dbContext.CatalogExercises.Add(exercise);
                _dbContext.SaveChanges();

                return exercise.Id;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public void LoadExercisesFromDatabase(List<CatalogExercise> exercises)
        {
            foreach (var item in exercises)
            {
                CatalogExercise newExercise = new CatalogExercise()
                {
                    Name = item.Name,
                    MuscleParts = item.MuscleParts
                };
                AddExerciseToDatabase(newExercise);
            }
        }

        public bool DoesExerciseExists(string exercisename)
        {
            return _dbContext.CatalogExercises.Any(p => p.Name == exercisename);
        }

        public static List<CatalogExercise> ReadCsv(string filePath, string delimiter)
        {
            List<CatalogExercise> exercises = new List<CatalogExercise>();

            try
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = delimiter,
                    HasHeaderRecord = true
                };

                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, config))
                {
                    exercises = csv.GetRecords<CatalogExercise>().ToList();
                }
                MessageBox.Show($"Cyk: {exercises.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas czytania pliku CSV: {ex.Message}");
            }

            return exercises;
        }

        public List<CatalogExercise> GetExercisesByMuscleParts(List<string> selectedMuscleParts)
        {
            string sqlQuery = "SELECT * FROM CatalogExercises WHERE ";
            for (int i = 0; i < selectedMuscleParts.Count; i++)
            {
                if (i > 0)
                    sqlQuery += " AND ";
                sqlQuery += $"MuscleParts LIKE '%{selectedMuscleParts[i]}%'";
            }
            return _dbContext.CatalogExercises
                .FromSqlRaw(sqlQuery)
                .ToList();
        }

        public List<CatalogExercise> GetExercisesBySearch(string search)
        {
            string sqlQuery = $"SELECT * FROM CatalogExercises WHERE Name LIKE '%{search}%'";
            return _dbContext.CatalogExercises.FromSqlRaw(sqlQuery).ToList();
        }

        public List<CatalogExercise> GetExercisesFromDB()
        {
            using (var context = new DBContext())
            {
                List<CatalogExercise> records = context.CatalogExercises.ToList();
                return records;
            }
        }
    }
}

