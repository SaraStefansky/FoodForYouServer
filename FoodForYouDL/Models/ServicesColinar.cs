﻿using System;
using System.Collections.Generic;

namespace FoodForYouDL.Models;

public partial class ServicesColinar
{
    public int Id { get; set; }

    public string Desc { get; set; } = null!;

    public virtual ICollection<Chef> Chefs { get; set; } = new List<Chef>();
}
