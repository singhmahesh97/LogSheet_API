using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class HistoricalDividend
{
    public decimal Id { get; set; }

    public string? SchemeName { get; set; }

    public string? PlanType { get; set; }

    public string? Nav { get; set; }

    public string? Date { get; set; }

    public string? IndividualDividendPerUnit { get; set; }

    public string? NonIndividualDividendPerUnit { get; set; }

    public string? IndividualDividendPercentage { get; set; }

    public string? NonIndividualDividendPercentage { get; set; }
}
