using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDotNetProjekt.Database.Models
{
    public class Training
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int User_ID { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
