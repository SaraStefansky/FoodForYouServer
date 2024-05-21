using FoodForYouDTO.DTO;

namespace FoodForYouBL
{
    public interface IRecipeBL
    {
        Task<bool> AddRecipe(RecipeDTO recipeDTO);
        Task<List<RecipeDTO>> GetAllRecipeByCategoryId(int categoryId);
        Task<List<RecipeDTO>> GetAllRecipeByChefId(int chefId);
        Task<List<RecipeDTO>> GetAllRecipes();
        Task<RecipeDTO> GetRecipeById(int recipeId);
        Task<bool> RemoveRecipe(int id);
        Task<bool> UpdateRecipe(RecipeDTO recipeDTO);
    }
}