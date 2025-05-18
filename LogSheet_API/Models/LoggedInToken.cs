using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class LoggedInToken
{
    public decimal TokenId { get; set; }

    public decimal UserId { get; set; }

    public string TokenNo { get; set; } = null!;

    public DateTime EffectiveFrom { get; set; }

    public DateTime ValidTill { get; set; }

    public string Active { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
