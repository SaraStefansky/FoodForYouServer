using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodForYouDL;
using FoodForYouDL.Models;

namespace FoodForYouDTO.DTO
{
    public class ChefDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        //public int? AreaId { get; set; }

        public int? ServiceId { get; set; }

        public string? Desc { get; set; }

        public string? UrlWebsite { get; set; }

        public string? Kosher { get; set; }

        public int? Phone { get; set; }

        //public virtual AreaDTO? Area { get; set; } = null!;

        public virtual ServicesColinarDTO? Service { get; set; } = null!;
    }
}
