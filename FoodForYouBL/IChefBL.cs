using FoodForYouDTO.DTO;

namespace FoodForYouBL
{
    public interface IChefBL
    {
        Task<ChefDTO> ChefLogin(ChefLoginDTO ChefLoginDTO);
        Task<ChefDTO> AddChef(ChefDTO chefDTO);
        Task<List<ChefDTO>> GetAllChefs();
        Task<List<ChefDTO>> GetAllChefsByServiceId(int serviceId);
        Task<ChefDTO> GetChefById(int chefId);
        Task<bool> UpdateChef(ChefDTO chefDTO);
    }
}