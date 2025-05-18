using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class FAQ
{
    public decimal ID { get; set; }

    public string Question { get; set; } = null!;

    public string? Answer { get; set; }

    public string? PublishStatus { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public decimal? underEditby { get; set; }

    public string? slug { get; set; }

    public decimal? CheckerlotID { get; set; }

    public decimal? CloneOfID { get; set; }

    public string? MarkAsDelete { get; set; }
}
