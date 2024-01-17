using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplikacjaDotNetProjekt.Database.Models
{
    public class Meal
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Meal_type { get; set; }

        public virtual ICollection<Recipe> Products { get; set; }
    }
}
