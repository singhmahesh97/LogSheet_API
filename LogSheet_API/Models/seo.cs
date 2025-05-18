using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class seo
{
    public decimal ID { get; set; }

    public string? siteurl { get; set; }

    public string? pagedesc { get; set; }

    public string? title { get; set; }

    public string? seodesc { get; set; }

    public string? seokeywords { get; set; }

    public string? seomisc { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public decimal? underEditBy { get; set; }

    public string? PublishStatus { get; set; }

    public decimal? CheckerLotId { get; set; }

    public decimal? CloneOfId { get; set; }

    public string? MarkAsDelete { get; set; }
}
