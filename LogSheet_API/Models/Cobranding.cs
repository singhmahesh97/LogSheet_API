using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class Cobranding
{
    public decimal Id { get; set; }

    public string? FundName { get; set; }

    public string? Name { get; set; }

    public string? ARN { get; set; }

    public string? Email { get; set; }

    public string? AddresLine1 { get; set; }

    public string? AddresLine2 { get; set; }

    public string? AddresLine3 { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? FileRegisterId { get; set; }
}
