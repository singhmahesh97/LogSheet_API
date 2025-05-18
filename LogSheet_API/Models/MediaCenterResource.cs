using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MediaCenterResource
{
    public decimal Id { get; set; }

    public string? Title { get; set; }

    public string? ExternalMediaUrl { get; set; }

    public decimal? FileRegisterId { get; set; }

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
