using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class StaticPageGeneratorDatum
{
    public decimal Id { get; set; }

    public string? Slug { get; set; }

    public string? content { get; set; }

    public string? PublishStatus { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public decimal? underEditby { get; set; }

    public decimal? CheckerlotID { get; set; }

    public decimal? CloneOfID { get; set; }
}
