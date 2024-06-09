using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public string? ItemName { get; set; }

    public string? Description { get; set; }

    public string? Price { get; set; }

    public int UserId { get; set; }

    public string? Photo { get; set; }

    public virtual ICollection<IndividualCooker> IndividualCookers { get; set; } = new List<IndividualCooker>();
}
