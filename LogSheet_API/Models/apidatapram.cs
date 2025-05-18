using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class apidatapram
{
    public decimal Id { get; set; }

    public decimal? FileId { get; set; }

    public string? MainCategory { get; set; }

    public string? VCLASS { get; set; }

    public string? VCLASSCODE { get; set; }
}
