using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class APIToken
{
    public decimal APITokenId { get; set; }

    public string? TokenNumber { get; set; }

    public string? ValidTill { get; set; }

    public string? Active { get; set; }
}
