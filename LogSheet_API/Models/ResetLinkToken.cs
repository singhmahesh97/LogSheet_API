using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class ResetLinkToken
{
    public decimal Id { get; set; }

    public decimal? UserId { get; set; }

    public string? EmailId { get; set; }

    public string? Token { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTill { get; set; }

    public string? Active { get; set; }

    public DateTime? CreatedDate { get; set; }
}
