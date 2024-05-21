using FoodForYouBL;
using FoodForYouDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodForYou.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CHEFSController : ControllerBase
    {
        IChefBL _CHEFSController;
        public CHEFSController(IChefBL chefController)
        {
            _CHEFSController = chefController;
        }

        [HttpPost]
        public async Task<ActionResult<ChefDTO>> AddChef(ChefDTO chefDTO)
        {
            if (chefDTO != null)
            {
                ChefDTO chef = await _CHEFSController.AddChef(chefDTO);
                if (chef != null)
                {
                    return Ok(chef);
                }

                else
                {
                    return NoContent();
                }
            }
            return null;

            //eturn await _CHEFSController.AddChef(chefDTO);
        }


        [HttpGet("service/{serviceId}")]
        public async Task<List<ChefDTO>> GetAllChefsByServiceId(int serviceId)
        {
            return await _CHEFSController.GetAllChefsByServiceId(serviceId);
        }

        [HttpGet]
        public async Task<List<ChefDTO>> GetAllChefs()
        {
            return await _CHEFSController.GetAllChefs();
        }

        [HttpGet("{chefId}")]
        public async Task<ChefDTO> GetChefById(int chefId)
        {
            return await _CHEFSController.GetChefById(chefId);
        }

        [HttpPut]
        public async Task<bool> UpdateChef(ChefDTO chefDTO)
        {
            return await _CHEFSController.UpdateChef(chefDTO);
        }

                [HttpPost("Login")]

        public async Task<ActionResult<ChefDTO>> ChefLogin([FromBody] ChefLoginDTO chef)

        {
            ChefDTO chefDTO = await _CHEFSController.ChefLogin(chef);
            if(chefDTO != null)
            {
                return Ok(chefDTO);
            }
            else
            {
                return NoContent();
            } 
        }
    }
}
