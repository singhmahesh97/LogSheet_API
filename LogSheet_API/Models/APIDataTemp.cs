using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class APIDataTemp
{
    public decimal Id { get; set; }

    public decimal? FileId { get; set; }

    public string? osch { get; set; }

    public string? csch { get; set; }

    public string? isch { get; set; }

    public string? STARTED_ON { get; set; }

    public string? MF_COCODE { get; set; }

    public string? SumOfTOTNAV { get; set; }

    public string? LNAME { get; set; }

    public string? FUND_TYPE { get; set; }

    public string? dateas { get; set; }

    public string? nameamc { get; set; }

    public string? address { get; set; }

    public string? telephone { get; set; }

    public string? website { get; set; }

    public string? email { get; set; }
}
