using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class UserRoleJoin
{
    public decimal Id { get; set; }

    public decimal? UserId { get; set; }

    public decimal? RoleId { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }
}
