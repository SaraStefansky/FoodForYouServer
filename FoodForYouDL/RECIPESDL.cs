using FoodForYouDL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouDL
{
    public class RECIPESDL : IRECIPESDL
    {
        FoodContext _FoodForYouContext = new FoodContext();
        public async Task<Recipe> GetRecipeById(int recipeId)
        {
            try
            {
                Recipe currentRecipe = await _FoodForYouContext.Recipes.SingleOrDefaultAsync(item => item.Id == recipeId);
                if (currentRecipe == null)
                {
                    throw new ArgumentException($"{recipeId} is not found");
                }


                return currentRecipe;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<Recipe>> GetAllRecipes()
        {
            List<Recipe> AllRecipes = await _FoodForYouContext.Recipes.ToListAsync();
            return AllRecipes;
        }
        public async Task<List<Recipe>> GetAllRecipeByCategoryId(int categoryId)
        {
            try
            {
                List<Recipe> RecipesByCategory = await _FoodForYouContext.Recipes.Where(item => item.CategoryId == categoryId)
             .ToListAsync();
                if (RecipesByCategory == null)
                {
                    throw new ArgumentException($"{categoryId} is not found");
                }


                return RecipesByCategory;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<List<Recipe>> GetAllRecipeByChefId(int chefId)
        {
            try
            {
                List<Recipe> RecipesByChef = await _FoodForYouContext.Recipes.Where(item => item.ChefId == chefId)
            .ToListAsync();
                if (RecipesByChef == null)
                {
                    throw new ArgumentException($"{chefId} is not found");
                }


                return RecipesByChef;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> AddRecipe(Recipe recipe)
        {
            try
            {
                await _FoodForYouContext.Recipes.AddAsync(recipe);
                _FoodForYouContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> RemoveRecipe(int id)
        {
            try
            {
                Recipe currentRecipe = await _FoodForYouContext.Recipes.FirstOrDefaultAsync(item => item.Id == id);
                if (currentRecipe == null)
                {
                    throw new ArgumentException($"{id} is not found");
                }
                _FoodForYouContext.Recipes.Remove(currentRecipe);
                await _FoodForYouContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateRecipe(Recipe recipe)
        {
            try
            {
                if (recipe == null)
                {
                    throw new ArgumentNullException(nameof(recipe), "Recipe object cannot be null.");
                }

                Recipe currentRecipe = await _FoodForYouContext.Recipes.SingleOrDefaultAsync(item => item.Id == recipe.Id);
                if (currentRecipe == null)
                {
                    throw new ArgumentException($"Recipe with Id {recipe.Id} is not found.");
                }

                currentRecipe.Name = recipe.Name;
                currentRecipe.Time = recipe.Time;
                currentRecipe.Desc = recipe.Desc;
                currentRecipe.UrlPic = recipe.UrlPic;
                currentRecipe.TypeId = recipe.TypeId;
                currentRecipe.LevelId = recipe.LevelId;
                currentRecipe.ChefId = recipe.ChefId;
                currentRecipe.CategoryId = recipe.CategoryId;

                await _FoodForYouContext.SaveChangesAsync();

                return true;
            }
            catch (DbUpdateException ex)
            {
                // Handle the database update exception appropriately
                throw new Exception("An error occurred while updating the recipe in the database.", ex);
            }
            catch (Exception ex)
            {
                // Handle other exceptions or rethrow if necessary
                throw;
            }
        }
    }
}
