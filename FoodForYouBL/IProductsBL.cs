using FoodForYouDTO.DTO;

namespace FoodForYouBL
{
    public interface IProductsBL
    {
        Task<bool> AddProduct(ProductDTO ProductsDTO);
        Task<List<ProductDTO>> GetProducts(int id);

        Task<bool> RemoveProduct(int id);
    }
}