using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MST009
{
    public decimal CountryId { get; set; }

    public string CountryCode { get; set; } = null!;

    public string CountryName { get; set; } = null!;

    public decimal? CurrencyId { get; set; }

    public string Active { get; set; } = null!;

    public decimal CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal LastModifiedBy { get; set; }

    public DateTime LastModifiedDate { get; set; }
}
