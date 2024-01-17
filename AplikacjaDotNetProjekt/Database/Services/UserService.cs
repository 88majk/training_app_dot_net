using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplikacjaDotNetProjekt.Database.Models;

namespace AplikacjaDotNetProjekt.Database.Services
{
    public class UserService
    {
        private readonly DBContext _dbContext;

        public UserService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User GetUserByName(string username)
        {
            // Pobierz użytkownika o danej nazwie z bazy danych
            return _dbContext.Users.FirstOrDefault(u => u.Name == username);
        }

        public int AddUserToDatabase(string username)
        {
            try
            {
                if (_dbContext.Users.Any(u => u.Name == username))
                {
                    return -2;
                }
                User user = new User();
                {
                    user.Name = username;
                }

                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();

                return user.Id;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
    }
}
