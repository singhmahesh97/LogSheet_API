using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class CapitalLineLIC_SchemeNAVHistoricalNew
{
    public decimal SchemeMasterId { get; set; }

    public decimal? FileId { get; set; }

    public DateTime? DateAndTime { get; set; }

    public string? MF_COCODE { get; set; }

    public string? MF_SCHCODE { get; set; }

    public string? NAVDATE { get; set; }

    public string? NAVRS { get; set; }

    public string? ADJNAVRS { get; set; }
}
