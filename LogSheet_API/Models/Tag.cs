using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class Tag
{
    public decimal Id { get; set; }

    public string? TagName { get; set; }

    public decimal? ParentTagId { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }
}
