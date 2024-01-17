using AplikacjaDotNetProjekt.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDotNetProjekt.Database.Services
{
    public class UserMealService
    {
        private readonly DBContext _dbContext;
        public UserMealService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddUserMeal(int userId, int mealId, string mealType, DateTime mealDate)
        {
            try
            {
                var userMeal = new UserMeal
                {
                    UserId = userId,
                    MealId = mealId,
                    MealType = mealType,
                    MealDate = mealDate
                };

                _dbContext.UserMeals.Add(userMeal);
                _dbContext.SaveChanges();
                return userMeal.Id;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public List<UserMeal> GetAllUserMeals()
        {
            return _dbContext.UserMeals.ToList();
        }

        public List<UserMeal> GetUserMealsForUser(int userId)
        {
            return _dbContext.UserMeals.Where(um => um.UserId == userId).ToList();
        }
        public List<UserMeal> GetUserMealsForDate(DateTime date, int userId)
        {
            return _dbContext.UserMeals
                .Where(um => um.MealDate.Date == date.Date && um.UserId == userId)
                .ToList();
        }
        public UserMeal GetUserMealsById(int userMealId)
        {
            return _dbContext.UserMeals
                .FirstOrDefault(um => um.Id == userMealId);
        }
    }
}
