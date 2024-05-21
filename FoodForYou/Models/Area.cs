using System;
using System.Collections.Generic;

namespace FoodForYou.Models;

public partial class Area
{
    public int Id { get; set; }

    public string Desc { get; set; } = null!;

    public virtual ICollection<Chef> Chefs { get; set; } = new List<Chef>();
}
