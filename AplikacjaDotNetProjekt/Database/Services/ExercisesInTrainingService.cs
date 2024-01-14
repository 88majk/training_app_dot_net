using AplikacjaDotNetProjekt.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDotNetProjekt.Database.Services
{
    public class ExercisesInTrainingService
    {
        private readonly DBContext _dbContext;

        public ExercisesInTrainingService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int SaveWorkout(ExercisesInTraining exercise)
        {
            try
            {
                _dbContext.Workouts.Add(exercise);
                _dbContext.SaveChanges();

                return exercise.Id;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

    }
}
