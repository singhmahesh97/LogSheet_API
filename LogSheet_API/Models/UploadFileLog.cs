using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class UploadFileLog
{
    public decimal UploadFileLogId { get; set; }

    public decimal? UploadTypeId { get; set; }

    public string? FilePath { get; set; }

    public string? FileName { get; set; }

    public string? Status { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? UploadedDataTime { get; set; }
}
