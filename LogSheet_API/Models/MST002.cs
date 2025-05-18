using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MST002
{
    public decimal UserDetailId { get; set; }

    public decimal UserId { get; set; }

    public string Active { get; set; } = null!;

    public decimal CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal LastModifiedBy { get; set; }

    public DateTime LastModifiedDate { get; set; }

    public string? EmailId { get; set; }

    public string? ProfileImageUrl { get; set; }

    public decimal? InvalidAttemptAllowed { get; set; }

    public DateOnly? DateOfJoining { get; set; }

    public decimal? Mobile { get; set; }

    public decimal? UserAccessTypeId { get; set; }
}
