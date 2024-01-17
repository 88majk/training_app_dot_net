using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDotNetProjekt.Database.Models
{
    public class UserMeal
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MealId { get; set; }
        public string MealType { get; set; }
        public DateTime MealDate { get; set; }
        public virtual Meal Meal { get; set; }
        public virtual User User { get; set; }
    }
}
