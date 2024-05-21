using System;
using System.Collections.Generic;

namespace FoodForYouDL.Models;

public partial class Recipe
{
    public int Id { get; set; }

    public int ChefId { get; set; }

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public int LevelId { get; set; }

    public int TypeId { get; set; }

    public string? UrlPic { get; set; }

    public string Desc { get; set; } = null!;

    public string Time { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual Chef Chef { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Instruction> Instructions { get; set; } = new List<Instruction>();

    public virtual Level Level { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<RecipesLike> RecipesLikes { get; set; } = new List<RecipesLike>();

    public virtual Type Type { get; set; } = null!;
}
