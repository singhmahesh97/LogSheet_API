using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class requesttable
{
    public decimal RequestID { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public decimal? SocketNo { get; set; }

    public decimal? RequestNo { get; set; }

    public string? URL { get; set; }

    public string? Status { get; set; }

    public DateTime? ProcessCompleteDateTime { get; set; }

    public string? ProcessFileName { get; set; }
}
