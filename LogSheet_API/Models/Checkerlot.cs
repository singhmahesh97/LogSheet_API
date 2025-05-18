using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class Checkerlot
{
    public decimal CheckerLotId { get; set; }

    public string? Description { get; set; }

    public string? CheckerStatus { get; set; }

    public decimal? CheckedBy { get; set; }

    public string? CheckerRemarks { get; set; }

    public DateTime? CheckerDate { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual ICollection<GpItem> GpItems { get; set; } = new List<GpItem>();
}
