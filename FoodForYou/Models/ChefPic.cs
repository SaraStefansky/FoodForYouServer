using System;
using System.Collections.Generic;

namespace FoodForYou.Models;

public partial class ChefPic
{
    public int Id { get; set; }

    public int ChefId { get; set; }

    public string UrlPic { get; set; } = null!;

    public virtual Chef Chef { get; set; } = null!;
}
