﻿using System;
using System.Collections.Generic;

namespace FoodForYouDL.Models;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<RecipesLike> RecipesLikes { get; set; } = new List<RecipesLike>();
}
