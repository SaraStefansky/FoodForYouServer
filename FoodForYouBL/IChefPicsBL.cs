using FoodForYouDTO.DTO;

namespace FoodForYouBL
{
    public interface IChefPicsBL
    {
        Task<bool> AddChefPic(ChefPicDTO chefPicDTO);
        Task<List<ChefPicDTO>> GetALLChefPic(int id);
    }
}