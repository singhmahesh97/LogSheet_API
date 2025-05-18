using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class tmpDownloadableType
{
    public decimal id { get; set; }

    public string? downloadablesId { get; set; }

    public string? slug { get; set; }
}
