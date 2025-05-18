using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MST014
{
    public decimal RoleEPTagId { get; set; }

    public decimal? RoleId { get; set; }

    public decimal? EPAuthTagId { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateOnly? LastModifiedDate { get; set; }

    public string? Active { get; set; }
}
