using System;
using System.Collections.Generic;

namespace FoodForYouDL.Models;

public partial class RecipesLike
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int RecipeId { get; set; }

    public virtual Recipe Recipe { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
