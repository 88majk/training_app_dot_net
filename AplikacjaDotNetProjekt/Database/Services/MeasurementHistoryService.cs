using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplikacjaDotNetProjekt.Database.Models;

namespace AplikacjaDotNetProjekt.Database.Services
{
    public class MeasurementHistoryService
    {
        private readonly DBContext _dbContext;

        public MeasurementHistoryService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddMeasurementToDatabase(MeasurementHistory measurementHistory)
        {
            try
            {
                _dbContext.measurementHistories.Add(measurementHistory);
                _dbContext.SaveChanges();
                return measurementHistory.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public List<MeasurementHistory> GetMeasurementHistory(int userID)
        {
            return _dbContext.measurementHistories
                .Where(history => history.userId == userID)
                .ToList();
        }
    }
}
