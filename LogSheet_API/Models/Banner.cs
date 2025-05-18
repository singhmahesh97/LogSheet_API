using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class Banner
{
    public decimal Id { get; set; }

    public string? Title { get; set; }

    public decimal? Order { get; set; }

    public string? Path { get; set; }

    public string? Active { get; set; }

    public string? Slug { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public decimal? underEditby { get; set; }

    public decimal? FileRegisterId { get; set; }

    public string? isfooter { get; set; }

    public string? PublishStatus { get; set; }

    public decimal? CheckerLotId { get; set; }

    public decimal? CloneOfId { get; set; }

    public string? MarkAsDelete { get; set; }
}
