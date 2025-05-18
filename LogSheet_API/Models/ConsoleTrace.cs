using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class ConsoleTrace
{
    public decimal ConsoleTraceId { get; set; }

    public string? Description { get; set; }

    public decimal? FileId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Status { get; set; }

    public string? SourceName { get; set; }
}
