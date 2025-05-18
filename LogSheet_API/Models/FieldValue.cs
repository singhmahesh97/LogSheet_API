using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class FieldValue
{
    public decimal Id { get; set; }

    public string? Feild { get; set; }

    public string? Value { get; set; }
}
