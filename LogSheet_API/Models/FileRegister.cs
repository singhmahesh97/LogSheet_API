using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class FileRegister
{
    public decimal Id { get; set; }

    public string? FileLocation { get; set; }

    public string? FileDisplayName { get; set; }

    public string? PublicUrl { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string? FileAlt { get; set; }

    public string? FileTitle { get; set; }
}
