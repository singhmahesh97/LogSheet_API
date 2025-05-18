using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class downloadabletype
{
    public decimal Id { get; set; }

    public string? Title { get; set; }

    public decimal? ParentId { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public decimal? underEditBy { get; set; }

    public string? slug { get; set; }

    public string? PublishStatus { get; set; }

    public decimal? CheckerlotID { get; set; }

    public decimal? CloneOfID { get; set; }

    public string? MarkAsDelete { get; set; }
}
