using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class user
{
    public decimal Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? LoginId { get; set; }

    public string? Password { get; set; }

    public decimal? ProfileImageUrl { get; set; }

    public string? EmailId { get; set; }

    public string? ContactNo { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public string? UserLocked { get; set; }

    public DateTime? LockedDate { get; set; }

    public int? InvalidAttempts { get; set; }

    public int? InvalidAttemptsAllowed { get; set; }

    public DateTime? LastPasswordChangedDate { get; set; }

    public decimal? RoleId { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual ICollection<Client> ClientCreatedByNavigations { get; set; } = new List<Client>();

    public virtual ICollection<Client> ClientModifiedByNavigations { get; set; } = new List<Client>();

    public virtual ICollection<GpItem> GpItemCreatedByNavigations { get; set; } = new List<GpItem>();

    public virtual ICollection<GpItem> GpItemModifiedByNavigations { get; set; } = new List<GpItem>();

    public virtual ICollection<GpType> GpTypeCreatedByNavigations { get; set; } = new List<GpType>();

    public virtual ICollection<GpType> GpTypeModifiedByNavigations { get; set; } = new List<GpType>();

    public virtual ICollection<LogSheet> LogSheets { get; set; } = new List<LogSheet>();

    public virtual ICollection<Solution> SolutionCreatedByNavigations { get; set; } = new List<Solution>();

    public virtual ICollection<Solution> SolutionModifiedByNavigations { get; set; } = new List<Solution>();
}
