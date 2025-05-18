using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class City
{
    public decimal Id { get; set; }

    public string? City1 { get; set; }

    public string? State { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public decimal? underEditBy { get; set; }

    public string? PublishStatus { get; set; }

    public decimal? CheckerLotId { get; set; }

    public decimal? CloneOfId { get; set; }

    public string? MarkAsDelete { get; set; }

    public string? Map { get; set; }
}
