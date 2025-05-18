using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class Career
{
    public decimal Id { get; set; }

    public string? Title { get; set; }

    public string? JobDescription { get; set; }

    public string? JobLocation { get; set; }

    public string? LocationType { get; set; }

    public DateTime? UploadDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Active { get; set; }

    public string? Slug { get; set; }

    public decimal? CreatedBy { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public decimal? underEditBy { get; set; }

    public string? PublishStatus { get; set; }

    public decimal? CheckerLotId { get; set; }

    public decimal? CloneOfId { get; set; }

    public string? MarkAsDelete { get; set; }
}
