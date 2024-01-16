using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDotNetProjekt.Database.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public float EnergyKcal { get; set; }
        public float Fat { get; set; }
        public float Carbohydrates { get; set; }
        public float Fiber { get; set; }
        public float Protein { get; set; }
        public float Salt { get; set; }

        public virtual ICollection<Recipe> Meals { get; set; }
    }
}
