using FoodForYouDL.Models;

namespace FoodForYouDL
{
    public interface ILookupDL
    {
        Task<List<Area>> GetAllAreas();
        Task<List<Category>> GetAllCategories();
        Task<List<Level>> GetAllLevels();
        Task<List<ServicesColinar>> GetAllServicesColinar();
        Task<List<Models.Type>> GetAllTypes();
    }
}