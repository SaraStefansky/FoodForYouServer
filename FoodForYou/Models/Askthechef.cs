using System;
using System.Collections.Generic;

namespace FoodForYou.Models;

public partial class Askthechef
{
    public int Id { get; set; }

    public int ChefId { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public DateTime Date { get; set; }

    public virtual Chef Chef { get; set; } = null!;
}
