using FoodForYouBL;
using FoodForYouDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodForYou.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RECIPESController : ControllerBase
    {
        IRecipeBL _RECIPESController;
        public RECIPESController(IRecipeBL RecipesController)
        {
            _RECIPESController = RecipesController;
        }
        // GET: api/<RECIPESController>
        [HttpPost]
        public async Task<bool> AddRecipe(RecipeDTO recipeDTO)
        {
            return await _RECIPESController.AddRecipe(recipeDTO);
        }

        [HttpGet("category/{categoryId}")]
        public async Task<List<RecipeDTO>> GetAllRecipeByCategoryId(int categoryId)
        {
            return await _RECIPESController.GetAllRecipeByCategoryId(categoryId);
        }

        [HttpGet("chef/{chefId}")]
        public async Task<List<RecipeDTO>> GetAllRecipeByChefId(int chefId)
        {
            return await _RECIPESController.GetAllRecipeByChefId(chefId);
        }

        [HttpGet]
        public async Task<List<RecipeDTO>> GetAllRecipes()
        {
            return await _RECIPESController.GetAllRecipes();
        }

        [HttpGet("{RecipeID}")]
        public async Task<RecipeDTO> GetRecipeById(int recipeId)
        {
            return await _RECIPESController.GetRecipeById(recipeId);
        }

        [HttpDelete("{idToRemove}")]
        public async Task<bool> RemoveRecipe(int id)
        {
            return await _RECIPESController.RemoveRecipe(id);
        }
       
        [HttpPut]
        public async Task<bool> UpdateRecipe(RecipeDTO recipeDTO)
        {
            return await _RECIPESController.UpdateRecipe(recipeDTO);
        }
    }
}
