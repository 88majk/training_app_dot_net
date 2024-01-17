using AplikacjaDotNetProjekt.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDotNetProjekt.Database.Services
{
    public class ProductService
    {
        private readonly DBContext _dbContext;

        public ProductService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddProductToDatabase(Product product)
        {
            try
            {
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();


                return product.Id;
            }
            catch (Exception e)
            {         
                return -1;
            }
        }
        public bool DoesProductExist(string productName)
        {
            return _dbContext.Products.Any(p => p.Nazwa == productName);
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            using (var context = new DBContext())
            {
                return await context.Products.ToListAsync();
            }
        }
        public Product GetProductByName(string productName)
        {
            // Pobierz produkt o danej nazwie z bazy danych
            return _dbContext.Products.FirstOrDefault(p => p.Nazwa == productName);
        }
    }
}
