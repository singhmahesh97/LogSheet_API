using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class lifecyclesBK
{
    public decimal Id { get; set; }

    public string? Title { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }
}
