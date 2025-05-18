using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class UploadTemplate
{
    public decimal Id { get; set; }

    public string? UploadType { get; set; }

    public string? TemplateUrl { get; set; }

    public string? DestinationUrl { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }
}
