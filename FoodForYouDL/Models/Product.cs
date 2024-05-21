using System;
using System.Collections.Generic;

namespace FoodForYouDL.Models;

public partial class Product
{
    public int Id { get; set; }

    public int RecipeId { get; set; }

    public string Desc { get; set; } = null!;

    public int Order { get; set; }

    public virtual Recipe Recipe { get; set; } = null!;
}
