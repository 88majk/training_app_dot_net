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
                    // Sprawdź, czy posiłek o danej nazwie już istnieje w bazie
                    bool mealExists = _dbContext.Meals.Any(m => m.Name == meal.Name);
                    if (mealExists)
                    {
                        // Jeśli już istnieje, zwróć -1 jako kod błędu
                        transaction.Rollback();
                        return -2;
                    }

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
    }
}
