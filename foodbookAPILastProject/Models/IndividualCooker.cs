using System;
using System.Collections.Generic;

namespace foodbookAPILastProject.Models;

public partial class IndividualCooker
{
    public int UserId { get; set; }

    public string CookerName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int MenuId { get; set; }

    public string ReviewId { get; set; } = null!;

    public virtual Menu Menu { get; set; } = null!;

    public virtual Review Review { get; set; } = null!;

    public virtual User? User { get; set; }
}
