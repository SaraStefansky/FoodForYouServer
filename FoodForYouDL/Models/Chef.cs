using System;
using System.Collections.Generic;

namespace FoodForYouDL.Models;

public partial class Chef
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? AreaId { get; set; }

    public int? ServiceId { get; set; }

    public string? Desc { get; set; }

    public string? UrlWebsite { get; set; }

    public string? Kosher { get; set; }

    public int? Phone { get; set; }

    public virtual Area? Area { get; set; }

    public virtual ICollection<Askthechef> Askthechefs { get; set; } = new List<Askthechef>();

    public virtual ICollection<ChefPic> ChefPics { get; set; } = new List<ChefPic>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual ServicesColinar? Service { get; set; }
}
