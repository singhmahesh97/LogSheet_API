using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MST006
{
    public decimal OfficeId { get; set; }

    public decimal? CompanyId { get; set; }

    public string OfficeCode { get; set; } = null!;

    public string OfficeName { get; set; } = null!;

    public decimal CountryId { get; set; }

    public decimal? CurrencyId { get; set; }

    public decimal Logo { get; set; }

    public string Active { get; set; } = null!;

    public decimal CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal LastModifiedBy { get; set; }

    public DateTime LastModifiedDate { get; set; }
}
