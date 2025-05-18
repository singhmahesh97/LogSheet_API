using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MST003
{
    public decimal GPTypeId { get; set; }

    public string SystemCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public string? Field4 { get; set; }

    public string? Field5 { get; set; }

    public string Active { get; set; } = null!;

    public decimal CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
