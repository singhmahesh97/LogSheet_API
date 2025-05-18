using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class CapitalLine_MFAllHolding1
{
    public decimal SchemeMasterId { get; set; }

    public decimal? FileId { get; set; }

    public DateTime? DateAndTime { get; set; }

    public string? CO_CODE { get; set; }

    public string? TYPECODE { get; set; }

    public string? PERC_HOLD { get; set; }

    public string? MKTVALUE { get; set; }

    public string? NO_SHARES { get; set; }

    public string? CO_NAME { get; set; }

    public string? IIND_NAME { get; set; }

    public string? mcaptype { get; set; }

    public string? TYPE { get; set; }

    public string? INVDATE { get; set; }

    public string? Rating { get; set; }

    public string? RatingAgency { get; set; }

    public string? ISIN { get; set; }

    public string? ReportedSector { get; set; }

    public string? YTM { get; set; }

    public string? YTC { get; set; }

    public string? sno { get; set; }

    public string? AMFICode { get; set; }
}
