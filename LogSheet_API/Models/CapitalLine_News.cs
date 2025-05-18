using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class CapitalLine_News
{
    public decimal Id { get; set; }

    public decimal? FileId { get; set; }

    public DateTime? DateAndTime { get; set; }

    public string? sno { get; set; }

    public string? section_name { get; set; }

    public string? date { get; set; }

    public string? time { get; set; }

    public string? heading { get; set; }

    public string? caption { get; set; }

    public string? arttext { get; set; }
}
