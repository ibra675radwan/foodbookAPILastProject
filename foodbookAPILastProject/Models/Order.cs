using System;
using System.Collections.Generic;

namespace foodbookAPILastProject.Models;

public partial class Order
{
    public string OrderId { get; set; } = null!;

    public int? Seller { get; set; }

    public string? OrderDescription { get; set; }

    public DateOnly? Date { get; set; }

    public string? Status { get; set; }

    public decimal? Ammount { get; set; }

    public string? PaymentMethod { get; set; }

    public int? Buyer { get; set; }

    public virtual User? BuyerNavigation { get; set; }

    public virtual User? SellerNavigation { get; set; }
}
