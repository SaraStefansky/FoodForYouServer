using FoodForYouDL.Models;

namespace FoodForYouDL
{
    public interface IRECIPESDL
    {
        Task<bool> AddRecipe(Recipe recipe);
        Task<List<Recipe>> GetAllRecipeByCategoryId(int categoryId);
        Task<List<Recipe>> GetAllRecipeByChefId(int chefId);
        Task<List<Recipe>> GetAllRecipes();
        Task<Recipe> GetRecipeById(int recipeId);
        Task<bool> RemoveRecipe(int id);
        Task<bool> UpdateRecipe(Recipe recipe);
    }
}