using AplikacjaDotNetProjekt.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
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
        public bool DoesExerciseExists(string exercisename)
        {
            return _dbContext.CatalogExercises.Any(p => p.Name == exercisename);
        }
    }
}
