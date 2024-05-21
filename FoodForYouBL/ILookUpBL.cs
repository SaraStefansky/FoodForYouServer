using FoodForYouDTO.DTO;

namespace FoodForYouBL
{
    public interface ILookUpBL
    {
        Task<List<AreaDTO>> GetAllAreas();
        Task<List<CategoryDTO>> GetAllCategories();
        Task<List<LevelDTO>> GetAllLevels();
        Task<List<ServicesColinarDTO>> GetAllServicesColinar();
        Task<List<TypeDTO>> GetAllTypes();
    }
}