using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class LogSheet
{
    public decimal Id { get; set; }

    public decimal? SolutionId { get; set; }

    public decimal? ClientId { get; set; }

    public decimal? TaskId { get; set; }

    public string? WorkStatus { get; set; }

    public string? LogDescription { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Client? Client { get; set; }

    public virtual user? CreatedByNavigation { get; set; }

    public virtual Solution? Solution { get; set; }

    public virtual GpItem? Task { get; set; }
}
