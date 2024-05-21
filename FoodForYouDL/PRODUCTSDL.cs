using FoodForYouDL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouDL
{
    public class PRODUCTSDL : IPRODUCTSDL
    {
        FoodContext _FoodForYouContext = new FoodContext();

        public async Task<bool> AddProduct(Product product)
        {
            try
            {
                await _FoodForYouContext.Products.AddAsync(product);
                await _FoodForYouContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Product>> GetProducts(int id)
        {
            try
            {
                List<Product> products = await _FoodForYouContext.Products
                .Where(item => item.Recipe.Id == id)
                .ToListAsync();

            return products;
        }
            catch (Exception ex)
            {
                throw ex;
            }
}
        public async Task<bool> RemoveProduct(int id)
        {
            try
            {
                Product currentProduct = await _FoodForYouContext.Products.FirstOrDefaultAsync(item => item.Id == id);
                if (currentProduct == null)
                {
                    throw new ArgumentException($"{id} is not found");
                }
                _FoodForYouContext.Products.Remove(currentProduct);
                await _FoodForYouContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
