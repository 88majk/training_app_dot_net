using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplikacjaDotNetProjekt.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;

namespace AplikacjaDotNetProjekt.Database.Services
{
    public class TrainingService
    {
        private readonly DBContext _dbContext;

        public TrainingService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddTrainingToDatabase(Training training)
        {
            try
            {
                _dbContext.Trainings.Add(training);
                _dbContext.SaveChanges();

                return training.Id;
            }
            catch (Exception ex) 
            {
                return -1;
            }
        }

        public bool DoesTrainingExists(string trainingName)
        {
            return _dbContext.Trainings.Any(p => p.Name == trainingName);    
        }

        public int GetTrainingIdByName(string trainingName)
        {
            Training training = _dbContext.Trainings.FirstOrDefault(e => e.Name == trainingName);


            return training != null ? training.Id : -1;
        }
    }
}
