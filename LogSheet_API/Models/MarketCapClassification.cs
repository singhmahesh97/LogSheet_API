using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MarketCapClassification
{
    public decimal Id { get; set; }

    public string? ISIN { get; set; }

    public string? Classification { get; set; }

    public DateTime? ExpiryDate { get; set; }
}
