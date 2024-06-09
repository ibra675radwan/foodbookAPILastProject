using System;
using System.Collections.Generic;

namespace foodbookAPILastProject.Models;

public partial class Restaurant
{
    public int RestaurantId { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public string? Mobilenumber { get; set; }

    public string UserName { get; set; } = null!;
}
