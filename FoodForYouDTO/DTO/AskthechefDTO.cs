using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodForYouDL;
using FoodForYouDL.Models;

namespace FoodForYouDTO.DTO
{
    public class AskthechefDTO
    {
        public int Id { get; set; }

        public int ChefId { get; set; }

        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Desc { get; set; } = null!;
        
        public DateTime Date { get; set; }

        //public virtual ChefDTO Chef { get; set; } = null!;
    }
}
