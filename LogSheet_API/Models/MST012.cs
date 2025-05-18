using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MST012
{
    public decimal EPAuthTagId { get; set; }

    public decimal? EndPointId { get; set; }

    public string? SystemTag { get; set; }

    public string? TagName { get; set; }

    public decimal? TagTypeId { get; set; }

    public string? DataSource { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateOnly? LastModifiedDate { get; set; }

    public string? Active { get; set; }
}
