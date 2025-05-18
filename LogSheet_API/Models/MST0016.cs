using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MST0016
{
    public decimal AccessTypeId { get; set; }

    public string RoleCode { get; set; } = null!;

    public string View { get; set; } = null!;

    public string Read { get; set; } = null!;

    public string Write { get; set; } = null!;

    public string Publish { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public decimal CreatedBy { get; set; }

    public DateTime LastModifiedDate { get; set; }
}
