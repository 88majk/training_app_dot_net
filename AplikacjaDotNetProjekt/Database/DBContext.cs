using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AplikacjaDotNetProjekt.Database.Models;

namespace AplikacjaDotNetProjekt.Database
{
    public class DBContext : DbContext
    {

        public DbSet<Product>? Products { get; set; }
        public DbSet<Meal>? Meals { get; set; }
        public DbSet<Recipe>? Recipes { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Models.CatalogExercise>? CatalogExercises { get; set; }
        public DbSet<Models.Training>? Trainings { get; set; }
        public DbSet<Models.ExercisesInTraining>? Workouts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DieteticApp;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }

        public List<CatalogExercise> GetExercisesFromDB()
        {
            using (var context = new DBContext())
            {
                List <CatalogExercise> records = context.CatalogExercises.ToList();
                return records;
            }
        }
    }
}
