using FoodForYouDL;
using FoodForYouDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouDTO.DTO
{
    public class RecipesLikeDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RecipeId { get; set; }

        public virtual RecipeDTO? Recipe { get; set; } = null!;

        public virtual UserDTO? User { get; set; } = null!;
    }
}
