using Microsoft.AspNetCore.Mvc;
using FoodForYouBL;
using FoodForYouDL.Models;
using Type = FoodForYouDL.Models.Type;
using FoodForYouDTO.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodForYou.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class lookupController : ControllerBase
    {
        ILookUpBL _LookUpController;
        public lookupController(ILookUpBL LookUpController)
        {
            _LookUpController = LookUpController;
        }

        [HttpGet("GetArea")]
        public async Task<List<AreaDTO>> GetAllAreas()
        {
            return await _LookUpController.GetAllAreas();
        }

        [HttpGet("GetCategories")]
        public async Task<List<CategoryDTO>> GetAllCategories()
        {
            return await _LookUpController.GetAllCategories();
        }
        [HttpGet("GetLevels")]
      
        public async Task<List<LevelDTO>> GetAllLevels()
        {
            return await  _LookUpController.GetAllLevels();    
        }

        [HttpGet("GetServicesColinar")]
        
        public async Task<List<ServicesColinarDTO>> GetAllServicesColinar()
        {
            return await _LookUpController.GetAllServicesColinar();
        }

        [HttpGet("GetTypes")]
       
        public async Task<List<TypeDTO>> GetAllTypes()
        {
            return await _LookUpController.GetAllTypes();
        }

    }
}
