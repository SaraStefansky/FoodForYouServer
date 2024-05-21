using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodForYouDL;
using FoodForYouDL.Models;

namespace FoodForYouDTO.DTO
{
    public class ChefPicDTO
    {
        public int Id { get; set; }

        public int ChefId { get; set; }

        public string UrlPic { get; set; } = null!;

        public virtual ChefDTO Chef { get; set; } = null!;
    }
}
