using AplikacjaDotNetProjekt.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDotNetProjekt.Database.Services
{
    public class RecipeService
    {
        private readonly DBContext _dbContext;

        public RecipeService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddProductToMeal(Meal meal, Product product, float weight)
        {
            var recipe = new Recipe
            {
                MealId = meal.Id,
                ProductId = product.Id,
                Weight = weight
            };

            _dbContext.Recipes.Add(recipe);
            _dbContext.SaveChanges();
        }

        public List<Product> GetProductsInMeal(int mealId)
        {
            return _dbContext.Recipes
                .Where(mp => mp.MealId == mealId)
                .Select(mp => mp.Product)
                .ToList();
        }
    }
}
