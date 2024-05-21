using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouDTO.DTO
{
    public class RecipeDTO
    {
        public int Id { get; set; }

        public int ChefId { get; set; }

        public string Name { get; set; } = null!;

        public int CategoryId { get; set; }

        public int LevelId { get; set; }

        public int TypeId { get; set; }

        public string? UrlPic { get; set; } = null!;

        public string Desc { get; set; } = null!;

        public string Time { get; set; } = null!;

        public virtual CategoryDTO Category { get; set; } = null!;

        public virtual ChefDTO Chef { get; set; } = null!;

        public virtual LevelDTO Level { get; set; } = null!;

        public virtual TypeDTO Type { get; set; } = null!;
    }
}
