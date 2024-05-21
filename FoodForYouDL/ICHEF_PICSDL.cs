using FoodForYouDL.Models;

namespace FoodForYouDL
{
    public interface ICHEF_PICSDL
    {
        Task<bool> AddChefPic(ChefPic chefPic);
        Task<List<ChefPic>> GetALLChefPic(int id);
    }
}