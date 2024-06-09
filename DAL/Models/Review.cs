using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Review
{
    public string ReviewId { get; set; } = null!;

    public int ByUserId { get; set; }

    public string Rating { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public DateOnly ReviewDate { get; set; }

    public int ToUserId { get; set; }

    public virtual User ByUser { get; set; } = null!;

    public virtual ICollection<IndividualCooker> IndividualCookers { get; set; } = new List<IndividualCooker>();
}
