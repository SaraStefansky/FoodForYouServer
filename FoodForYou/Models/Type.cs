using System;
using System.Collections.Generic;

namespace FoodForYou.Models;

public partial class Type
{
    public int Id { get; set; }

    public string Desc { get; set; } = null!;

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
