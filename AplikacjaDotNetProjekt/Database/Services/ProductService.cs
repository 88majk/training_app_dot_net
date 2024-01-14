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

                // Zwróć ID nowo dodanego produktu
                return product.Id;
            }
            catch (Exception ex)
            {         
                return -1; // Lub inna wartość oznaczająca błąd
            }
        }
        public bool DoesProductExist(string productName)
        {
            // Sprawdź, czy produkt o danej nazwie istnieje w bazie danych
            return _dbContext.Products.Any(p => p.Nazwa == productName);
        }
    }
}
