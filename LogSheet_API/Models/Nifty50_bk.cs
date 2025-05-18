using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class Nifty50_bk
{
    public decimal Nifty50id { get; set; }

    public DateTime? PDate { get; set; }

    public decimal? Value { get; set; }
}
