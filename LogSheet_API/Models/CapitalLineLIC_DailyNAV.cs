using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class CapitalLineLIC_DailyNAV
{
    public decimal Id { get; set; }

    public DateTime? DateAndTime { get; set; }

    public string? mf_schcode { get; set; }

    public string? ISIN { get; set; }

    public string? AMFICode { get; set; }

    public string? mf_schname { get; set; }

    public string? navdate { get; set; }

    public string? NAV { get; set; }

    public string? RePurchaseNAV { get; set; }

    public string? SellNav { get; set; }

    public string? Tax_Type { get; set; }
}
