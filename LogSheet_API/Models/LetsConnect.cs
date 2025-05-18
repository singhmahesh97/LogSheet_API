using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class LetsConnect
{
    public decimal Id { get; set; }

    public string? UserName { get; set; }

    public string? MobileNo { get; set; }

    public string? LetsConnectType { get; set; }

    public string? Email { get; set; }

    public string? Comments { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? City { get; set; }
}
