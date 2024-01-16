using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDotNetProjekt.Database.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public int ProductId { get; set; }
        public float Weight { get; set; }

        public virtual Meal Meal { get; set; }
        public virtual Product Product { get; set; }
    }
}
