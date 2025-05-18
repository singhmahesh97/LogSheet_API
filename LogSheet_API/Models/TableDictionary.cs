using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class TableDictionary
{
    public decimal Id { get; set; }

    public string TableName { get; set; } = null!;

    public string AliasName { get; set; } = null!;
}
