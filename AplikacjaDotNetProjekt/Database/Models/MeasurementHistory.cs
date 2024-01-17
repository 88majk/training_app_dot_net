using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDotNetProjekt.Database.Models
{
    public class MeasurementHistory
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public string Date { get; set; }
        public float userWeight { get; set; }
        public float userHeight { get; set; }
        public float armCircuit { get; set; }
        public float chestCircuit { get; set; }
    }

    public class MeasurementHistoryDisplay
    {
        public string Date { get; set; }
        public float userWeight { get; set; }
        public float userHeight { get; set; }
        public float armCircuit { get; set; }
        public float chestCircuit { get; set; }
    }
}
