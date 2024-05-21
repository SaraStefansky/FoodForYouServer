using FoodForYouDL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouDL
{
    public class RECIPES_LIKEDL : IRECIPES_LIKEDL
    {
        FoodContext _FoodForYouContext = new FoodContext();
        public async Task<List<RecipesLike>> GetRecipesLikes(int id)
        {
            try
            {
                List<RecipesLike> RecipesLikes = await _FoodForYouContext.RecipesLikes
                .Where(item => item.User.Id == id)
                .ToListAsync();

            return RecipesLikes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> AddRecipesLike(RecipesLike recipesLike)
        {
            try
            {
                await _FoodForYouContext.RecipesLikes.AddAsync(recipesLike);
                _FoodForYouContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> RemoveRecipesLike(int id)
        {
            try
            {
                RecipesLike currentRecipesLike = await _FoodForYouContext.RecipesLikes.FirstOrDefaultAsync(item => item.Id == id);
                if (currentRecipesLike == null)
                {
                    throw new ArgumentException($"{id} is not found");
                }
                _FoodForYouContext.RecipesLikes.Remove(currentRecipesLike);
                await _FoodForYouContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
