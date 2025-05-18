using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class GpItem
{
    public decimal ID { get; set; }

    public decimal? GpTypeId { get; set; }

    public string? ShortDescription { get; set; }

    public string? LongDescription { get; set; }

    public string? Active { get; set; }

    public string? MarkedForDelete { get; set; }

    public decimal? CheckerLotId { get; set; }

    public string? CheckerStatus { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Checkerlot? CheckerLot { get; set; }

    public virtual user? CreatedByNavigation { get; set; }

    public virtual GpType? GpType { get; set; }

    public virtual ICollection<LogSheet> LogSheets { get; set; } = new List<LogSheet>();

    public virtual user? ModifiedByNavigation { get; set; }
}
