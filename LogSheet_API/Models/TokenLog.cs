using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class TokenLog
{
    public decimal TokenId { get; set; }

    public decimal? UserId { get; set; }

    public string? TokenNo { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? ExpiryDate { get; set; }
}
