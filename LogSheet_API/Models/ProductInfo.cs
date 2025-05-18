using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class ProductInfo
{
    public decimal ID { get; set; }

    public string? Title { get; set; }

    public string? ISIN { get; set; }

    public decimal? SchemeCategoryId { get; set; }

    public string? Amficode { get; set; }

    public decimal? ProductID { get; set; }

    public string? PublishStatus { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string? mf_schcode { get; set; }

    public decimal? CheckerlotID { get; set; }

    public decimal? CloneOfID { get; set; }

    public string? BatchId { get; set; }
}
