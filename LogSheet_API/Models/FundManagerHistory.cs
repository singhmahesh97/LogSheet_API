using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class FundManagerHistory
{
    public decimal ID { get; set; }

    public decimal? ProductID { get; set; }

    public decimal? FundManagerID { get; set; }

    public DateTime? ManagingFrom { get; set; }

    public DateTime? ManagingTo { get; set; }

    public int? FMSequence { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public decimal? underEditBy { get; set; }

    public string? PublishStatus { get; set; }

    public decimal? CheckerlotID { get; set; }

    public decimal? CloneOfID { get; set; }

    public string? BatchId { get; set; }
}
