using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class GpType
{
    public decimal Id { get; set; }

    public string? GpTypeCode { get; set; }

    public string? GpTypeDescription { get; set; }

    public string? SystemDataFlag { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual user? CreatedByNavigation { get; set; }

    public virtual ICollection<GpItem> GpItems { get; set; } = new List<GpItem>();

    public virtual user? ModifiedByNavigation { get; set; }
}
