using FoodForYouDL.Models;

namespace FoodForYouDL
{
    public interface ICHEFSDL
    {
        Task<Chef> ChefLogin(string email, string password); 
        Task<Chef> AddChef(Chef chef);
        Task<List<Chef>> GetAllChefs();
        Task<List<Chef>> GetAllChefsByServiceId(int serviceId);
        Task<Chef> GetChefById(int chefId);
        Task<bool> UpdateChef(Chef chef);
    }
}