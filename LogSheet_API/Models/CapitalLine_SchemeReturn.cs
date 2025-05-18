using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class CapitalLine_SchemeReturn
{
    public decimal SchemeMasterId { get; set; }

    public decimal? FileId { get; set; }

    public DateTime? DateAndTime { get; set; }

    public string? Schemecode { get; set; }

    public string? Schemename { get; set; }

    public string? Day1_Ret { get; set; }

    public string? Day3_Ret { get; set; }

    public string? Week1_Ret { get; set; }

    public string? Day14_Ret { get; set; }

    public string? Month1_Ret { get; set; }

    public string? Month3_Ret { get; set; }

    public string? Month6_Ret { get; set; }

    public string? YTD_Ret { get; set; }

    public string? year1_Ret { get; set; }

    public string? Year3_Ret { get; set; }

    public string? Year5_Ret { get; set; }

    public string? Year7_Ret { get; set; }

    public string? Year10_Ret { get; set; }

    public string? Inception_Ret { get; set; }

    public string? ReturnDate { get; set; }
}
