using FoodForYouDTO.DTO;

namespace FoodForYouBL
{
    public interface IRecipesLikeBL
    {
        Task<bool> AddRecipesLike(RecipesLikeDTO recipesLikeDTO);
        Task<List<RecipesLikeDTO>> GetRecipesLikes(int id);

        Task<bool> RemoveRecipesLike(int id);
    }
}