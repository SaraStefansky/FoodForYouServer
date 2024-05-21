using FoodForYouBL;
using FoodForYouDL.Models;
using FoodForYouDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodForYou.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CHEF_PICSController : ControllerBase
    {
        IChefPicsBL _CHEF_PICSController;
        public CHEF_PICSController(IChefPicsBL chefPicsController)
        {
            _CHEF_PICSController = chefPicsController;
        }


        // GET api/<PRODUCTSController>/5

        [HttpGet("{id}")]
        public async Task<List<ChefPicDTO>> GetALLChefPic(int id)
        {
            return await Task.Run(() =>  _CHEF_PICSController.GetALLChefPic(id));
        }

        [HttpPost]
        public async Task<bool> AddChefPic(ChefPicDTO chefPicDTO)
        {
            return await Task.Run(() => _CHEF_PICSController.AddChefPic(chefPicDTO));
        }
    }
}
