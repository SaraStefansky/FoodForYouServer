using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouDTO.DTO
{
    public class ChefLoginDTO
    {
        [EmailAddress]
        public string email { get; set; }

        [PasswordPropertyText]
        public string password { get; set; }

    }
}
