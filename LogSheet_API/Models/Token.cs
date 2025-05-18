using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class Token
{
    public decimal TokenId { get; set; }

    public decimal? UserId { get; set; }

    public string? TokenNo { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTill { get; set; }

    public string? Active { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal LastModifiedBy { get; set; }

    public DateTime LastModifiedDate { get; set; }
}
