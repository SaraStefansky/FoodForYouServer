using System;
using System.Collections.Generic;

namespace FoodForYou.Models;

public partial class Instruction
{
    public int Id { get; set; }

    public int RecipeId { get; set; }

    public string Desc { get; set; } = null!;

    public int Order { get; set; }

    public virtual Recipe Recipe { get; set; } = null!;
}
