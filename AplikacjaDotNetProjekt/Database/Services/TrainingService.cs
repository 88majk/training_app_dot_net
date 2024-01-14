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
        private readonly DBContext _dBContext;

        public TrainingService(DBContext dbContext)
        {
            _dBContext = dbContext;
        }

        public int AddTrainingToDatabase(Training training)
        {
            try
            {
                _dBContext.Trainings.Add(training);
                _dBContext.SaveChanges();

                return training.Id;
            }
            catch (Exception ex) 
            {
                return -1;
            }
        }

        public bool DoesTrainingExists(string trainingName)
        {
            return _dBContext.Trainings.Any(p => p.Name == trainingName);    
        }
    }
}
