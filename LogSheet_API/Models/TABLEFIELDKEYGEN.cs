using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class TABLEFIELDKEYGEN
{
    public decimal TABLEFIELDKEYGEN_ID { get; set; }

    public string TABLENAME { get; set; } = null!;

    public string FIELD { get; set; } = null!;

    public string KEYGENEXPRESSION { get; set; } = null!;

    public decimal RUNNINGNUMBER { get; set; }

    public string RESETAT { get; set; } = null!;

    public decimal? OFFICEID { get; set; }

    public DateOnly? VALIDFROM { get; set; }

    public DateOnly? VALIDTILL { get; set; }
}
