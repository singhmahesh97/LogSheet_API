using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class FundManager
{
    public decimal Id { get; set; }

    public string? Name { get; set; }

    public string? Title { get; set; }

    public string? OtherFundsManaged { get; set; }

    public string? Description { get; set; }

    public string? Photo { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public decimal? underEditBy { get; set; }

    public decimal? FileRegisterId { get; set; }

    public string? PublishStatus { get; set; }

    public decimal? CheckerlotID { get; set; }

    public decimal? CloneOfID { get; set; }

    public string? MarkAsDelete { get; set; }
}
