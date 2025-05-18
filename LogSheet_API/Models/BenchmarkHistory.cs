using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class BenchmarkHistory
{
    public decimal Id { get; set; }

    public decimal? ProductId { get; set; }

    public decimal? BenchmarkId { get; set; }

    public int? BMSequence { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }
}
