using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class Dividend
{
    public decimal ID { get; set; }

    public string? Title { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? PublishStatus { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public decimal? underEditBy { get; set; }

    public string? slug { get; set; }

    public decimal? FileRegisterId { get; set; }

    public decimal? CheckerlotID { get; set; }

    public decimal? CloneOfID { get; set; }
}
