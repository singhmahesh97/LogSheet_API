using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class SEOBase
{
    public decimal ID { get; set; }

    public string? siteurl { get; set; }

    public string? pagedesc { get; set; }

    public string? seotitle { get; set; }

    public string? seodesc { get; set; }

    public string? seokeywords { get; set; }

    public string? seomisc { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public decimal? underEditBy { get; set; }
}
