using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class Solution
{
    public decimal Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual user? CreatedByNavigation { get; set; }

    public virtual ICollection<LogSheet> LogSheets { get; set; } = new List<LogSheet>();

    public virtual user? ModifiedByNavigation { get; set; }
}
