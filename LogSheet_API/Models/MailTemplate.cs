using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MailTemplate
{
    public int MailTemplateId { get; set; }

    public decimal? TemplateTypeId { get; set; }

    public string TemplateName { get; set; } = null!;

    public string MailSubject { get; set; } = null!;

    public string MailBody { get; set; } = null!;

    public string Active { get; set; } = null!;

    public int? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? LastModifiedBy { get; set; }

    public DateTime LastModifiedDate { get; set; }

    public virtual MST004? TemplateType { get; set; }
}
