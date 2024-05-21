using FoodForYouDL.Models;

namespace FoodForYouDL
{
    public interface IRECIPES_LIKEDL
    {
        Task<bool> AddRecipesLike(RecipesLike recipesLike);
        Task<List<RecipesLike>> GetRecipesLikes(int id);
        Task<bool> RemoveRecipesLike(int id);
    }
}