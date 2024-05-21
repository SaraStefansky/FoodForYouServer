using AutoMapper;
using FoodForYouDL.Models;
using FoodForYouDL;
using FoodForYouDTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouBL
{
    public class RecipesLikeBL : IRecipesLikeBL
    {
        IRECIPES_LIKEDL _RecipesLikeBL;
        private IMapper Mapper;

        public RecipesLikeBL(IRECIPES_LIKEDL recipesLikeBL, IMapper mapper)
        {
            _RecipesLikeBL = recipesLikeBL;
            Mapper = mapper;

        }
        public async Task<bool> AddRecipesLike(RecipesLikeDTO recipesLikeDTO)
        {
            var recipesLike = Mapper.Map<RecipesLike>(recipesLikeDTO);
            return await _RecipesLikeBL.AddRecipesLike(recipesLike);
        }

        public async Task<List<RecipesLikeDTO>> GetRecipesLikes(int id)
        {
            var RecipesLikes = await Task.Run(() => _RecipesLikeBL.GetRecipesLikes(id));
            List<RecipesLikeDTO> RecipesLikeDTOs = Mapper.Map<List<RecipesLikeDTO>>(RecipesLikes);
            return RecipesLikeDTOs;
        }
        public async Task<bool> RemoveRecipesLike(int id)
        {
            return await Task.Run(() => _RecipesLikeBL.RemoveRecipesLike(id));

        }
    }
}
