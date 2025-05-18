using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MST008
{
    public decimal UserOfficeRoleJoinId { get; set; }

    public string UserId { get; set; } = null!;

    public string OfficeId { get; set; } = null!;

    public string RoleId { get; set; } = null!;

    public string DefaultFlag { get; set; } = null!;

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTill { get; set; }

    public string Active { get; set; } = null!;

    public decimal CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal LastModifiedBy { get; set; }

    public DateTime LastModifiedDate { get; set; }
}
