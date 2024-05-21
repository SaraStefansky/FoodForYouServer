using FoodForYouDL;
using FoodForYouDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouDTO.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }

        public string Desc { get; set; } = null!;

        public int Order { get; set; }

        public virtual RecipeDTO Recipe { get; set; } = null!;
    }
}
