using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MST001
{
    public decimal UserId { get; set; }

    public string Code { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string LoginId { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? LastLoginDate { get; set; }

    public string UserLocked { get; set; } = null!;

    public DateTime? LockedDate { get; set; }

    public decimal? InvalidAttempts { get; set; }

    public DateTime? LastPasswordChangedDate { get; set; }

    public string Active { get; set; } = null!;

    public decimal CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal LastModifiedBy { get; set; }

    public DateTime LastModifiedDate { get; set; }
}
