using System;
using System.Collections.Generic;

namespace FoodForYou.Models;

public partial class Comment
{
    public int Id { get; set; }

    public int RecipeId { get; set; }

    public string Desc { get; set; } = null!;

    public DateOnly Date { get; set; }

    public int UserId { get; set; }

    public virtual Recipe Recipe { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
