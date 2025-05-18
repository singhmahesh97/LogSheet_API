using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class IndexConstituent
{
    public decimal id { get; set; }

    public string? scheme_code { get; set; }

    public string? isin { get; set; }

    public string? security_name { get; set; }

    public string? weightage { get; set; }

    public string? upload_date { get; set; }
}
