using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class TmpNav
{
    public decimal TmpNavId { get; set; }

    public decimal? FileRegisterId { get; set; }

    public string? AMFICode { get; set; }

    public string? SchemeName { get; set; }

    public string? NAVDate { get; set; }

    public string? NAV { get; set; }

    public string? Status { get; set; }

    public string? ErrorRemarks { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
