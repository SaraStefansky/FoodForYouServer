using AutoMapper;
using FoodForYouDL;
using FoodForYouDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodForYouDTO.DTO;

namespace FoodForYouBL
{
    public class RecipeBL : IRecipeBL
    {
        IRECIPESDL _RecipeBL;
        private IMapper Mapper;

        public RecipeBL(IRECIPESDL recipesBL, IMapper mapper)
        {
            _RecipeBL = recipesBL;
            Mapper = mapper;

        }
        public async Task<bool> AddRecipe(RecipeDTO recipeDTO)
        {
            var recipe = Mapper.Map<Recipe>(recipeDTO);
            return await Task.Run(() => _RecipeBL.AddRecipe(recipe));
        }
        public async Task<List<RecipeDTO>> GetAllRecipeByCategoryId(int categoryId)
        {
            var RecipeByCategoryId = await Task.Run(() => _RecipeBL.GetAllRecipeByCategoryId(categoryId));
            List<RecipeDTO> RecipeByCategoryIdDTO = Mapper.Map<List<RecipeDTO>>(RecipeByCategoryId);
            return RecipeByCategoryIdDTO;
        }
        public async Task<List<RecipeDTO>> GetAllRecipeByChefId(int chefId)
        {
            var RecipeByChefId = await Task.Run(() => _RecipeBL.GetAllRecipeByChefId(chefId));
            List<RecipeDTO> RecipeByChefIdDTO = Mapper.Map<List<RecipeDTO>>(RecipeByChefId);
            return RecipeByChefIdDTO;
        }
        public async Task<List<RecipeDTO>> GetAllRecipes()
        {
            var AllRecipes = await Task.Run(() => _RecipeBL.GetAllRecipes());
            List<RecipeDTO> AllRecipesDTO = Mapper.Map<List<RecipeDTO>>(AllRecipes);
            return AllRecipesDTO;
        }
        public async Task<RecipeDTO> GetRecipeById(int recipeId)
        {
            var RecipeById = await Task.Run(() => _RecipeBL.GetRecipeById(recipeId));
            RecipeDTO RecipeByIdDTO = Mapper.Map<RecipeDTO>(RecipeById);
            return RecipeByIdDTO;
        }
        public async Task<bool> RemoveRecipe(int id)
        {
            return await Task.Run(() => _RecipeBL.RemoveRecipe(id));
        }
        public async Task<bool> UpdateRecipe(RecipeDTO recipeDTO)
        {
            var currentrecipe = Mapper.Map<Recipe>(recipeDTO);
            return await Task.Run(() => _RecipeBL.AddRecipe(currentrecipe));

        }
    }
}
