using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class FileInputTemplate
{
    public int FileInputTemplateId { get; set; }

    public decimal? FileTypeId { get; set; }

    public string TemplateName { get; set; } = null!;

    public string? TemplateDescription { get; set; }

    public string TemplateURL { get; set; } = null!;

    public string DestinationURL { get; set; } = null!;

    public string Active { get; set; } = null!;

    public decimal? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime LastModifiedDate { get; set; }

    public virtual MST004? FileType { get; set; }
}
