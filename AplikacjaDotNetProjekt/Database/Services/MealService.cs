using AplikacjaDotNetProjekt.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AplikacjaDotNetProjekt.Database.Services
{
    public class MealService
    {
        private readonly DBContext _dbContext;

        public MealService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddMealToDatabase(Meal meal, List<Product> products, List<float> weights)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    // Dodaj posiłek do bazy danych
                    _dbContext.Meals.Add(meal);
                    _dbContext.SaveChanges();

                    // Dodaj produkty do posiłku wraz z wagami do tabeli pośredniczącej
                    for (int i = 0; i < products.Count(); i++)
                    {
                        Recipe recipe = new Recipe();
                        {
                            recipe.MealId = meal.Id;
                            recipe.ProductId = products[i].Id;
                            recipe.Weight = weights[i];
                        }

                        // Dodaj do bazy danych
                        _dbContext.Recipes.Add(recipe);
                    }

                    _dbContext.SaveChanges();
                    transaction.Commit();

                    return meal.Id;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return -1;
                }
            }
        }
        public Meal GetMealById(int mealId)
        {
            return _dbContext.Meals.FirstOrDefault(m => m.Id == mealId && !m.Name.Contains("_"));
        }
        public Meal GetMealByIdWith(int mealId)
        {
            return _dbContext.Meals.FirstOrDefault(m => m.Id == mealId);
        }
        public Meal GetMealByName(string mealName)
        {
            return _dbContext.Meals.FirstOrDefault(m => m.Name == mealName);
        }
        public string GetLastMealNameFromDatabase(string prefix)
        {
            // Pobierz ostatnią nazwę posiłku, jeżeli istnieje
            var lastMeal = _dbContext.Meals
                .Where(m => m.Name.StartsWith(prefix))
                .OrderByDescending(m => m.Id)
                .FirstOrDefault();

            return lastMeal?.Name;
            
        }
    }
}
