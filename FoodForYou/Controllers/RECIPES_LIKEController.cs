using FoodForYouBL;
using FoodForYouDL;
using FoodForYouDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodForYou.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RECIPES_LIKEController : ControllerBase
    {
        IRecipesLikeBL _RECIPES_LIKEController;
        public RECIPES_LIKEController(IRecipesLikeBL RecipesLikeController)
        {
            _RECIPES_LIKEController = RecipesLikeController;
        }


        // GET api/<PRODUCTSController>/5

        [HttpGet("{id}")]
        public async Task<List<RecipesLikeDTO>> GetRecipesLikes(int id)
        {
            return await _RECIPES_LIKEController.GetRecipesLikes(id);
        }

        [HttpPost]
        public async Task<bool> AddRecipesLike(RecipesLikeDTO recipesLikeDTO)
        {
            return await _RECIPES_LIKEController.AddRecipesLike(recipesLikeDTO);
        }
        // Delete api/<PRODUCTSController>
        [HttpDelete("{id}")]
        public async Task<bool> RemoveRecipesLike(int id)

        {
            return await _RECIPES_LIKEController.RemoveRecipesLike(id);
        }
    }
}
