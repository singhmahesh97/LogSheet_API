using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MST004
{
    public decimal GPId { get; set; }

    public decimal? ParentGPId { get; set; }

    public decimal GPTypeId { get; set; }

    public string SystemCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public string? Field4 { get; set; }

    public string? Field5 { get; set; }

    public string Active { get; set; } = null!;

    public decimal CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual ICollection<FileInputTemplate> FileInputTemplates { get; set; } = new List<FileInputTemplate>();

    public virtual ICollection<MailTemplate> MailTemplates { get; set; } = new List<MailTemplate>();
}
