using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MST013
{
    public decimal EPAuthTagDetailId { get; set; }

    public decimal? EPAuthTagId { get; set; }

    public string? RefData { get; set; }

    public string? Active { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public decimal? CreatedBy { get; set; }

    public decimal? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public decimal? LastModifiedDate { get; set; }
}
