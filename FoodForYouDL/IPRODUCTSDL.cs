using FoodForYouDL.Models;

namespace FoodForYouDL
{
    public interface IPRODUCTSDL
    {
        Task<bool> AddProduct(Product product);
        Task<List<Product>> GetProducts(int id);
        Task<bool> RemoveProduct(int id);
    }
}