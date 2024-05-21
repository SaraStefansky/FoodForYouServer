using FoodForYouDL;
using FoodForYouDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = FoodForYouDL.Models.Type;


namespace FoodForYouDTO.DTO
{
    public class TypeDTO
    {
        public int Id { get; set; }

        public string Desc { get; set; } = null!;
    }
}
