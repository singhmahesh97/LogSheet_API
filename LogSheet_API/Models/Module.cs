using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class Module
{
    public decimal ModuleID { get; set; }

    public string TableName { get; set; } = null!;

    public string? Description { get; set; }

    public string MailSubject { get; set; } = null!;

    public string MailDescription { get; set; } = null!;

    public decimal? DaysBefore { get; set; }

    public string? Active { get; set; }
}
