using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class NavDatum
{
    public decimal NavDataId { get; set; }

    public decimal? FileRegisterId { get; set; }

    public string? AMFICode { get; set; }

    public string? SchemeName { get; set; }

    public string? NAVDate { get; set; }

    public decimal? NAV { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
