using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MST015
{
    public decimal RoleEPTagDetailId { get; set; }

    public decimal? RoleEPTagId { get; set; }

    public decimal? EPAuthTagDetailId { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateOnly? LastModifiedDate { get; set; }

    public string? Active { get; set; }
}
