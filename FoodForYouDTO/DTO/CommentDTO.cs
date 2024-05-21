using FoodForYouDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodForYouDL;


namespace FoodForYouDTO.DTO
{
    public class CommentDTO
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }

        public string Desc { get; set; } = null!;

        public DateOnly Date { get; set; }

        public int UserId { get; set; }

        public virtual RecipeDTO Recipe { get; set; } = null!;

        public virtual UserDTO User { get; set; } = null!;
    }
}
