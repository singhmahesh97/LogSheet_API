using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class CheckerLotBk
{
    public decimal CheckerLotId { get; set; }

    public string? ModuleName { get; set; }

    public string? Description { get; set; }

    public string? CheckerStatus { get; set; }

    public decimal? CheckedBy { get; set; }

    public string? CheckerRemarks { get; set; }

    public DateTime? CheckerDate { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }
}
