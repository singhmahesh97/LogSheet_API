using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class SIPPerformance
{
    public decimal Id { get; set; }

    public string? FactDate { get; set; }

    public string? fundcode { get; set; }

    public string? fundname { get; set; }

    public string? sipinvestments { get; set; }

    public string? Year1 { get; set; }

    public string? Year3 { get; set; }

    public string? Year5 { get; set; }

    public string? Year7 { get; set; }

    public string? Year10 { get; set; }

    public string? SinceInception { get; set; }

    public string? Mapping { get; set; }
}
