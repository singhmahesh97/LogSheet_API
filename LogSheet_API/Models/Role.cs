using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class Role
{
    public decimal Id { get; set; }

    public string SystemCode { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Active { get; set; } = null!;

    public decimal CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal LastModifiedBy { get; set; }

    public DateTime LastModifiedDate { get; set; }
}
