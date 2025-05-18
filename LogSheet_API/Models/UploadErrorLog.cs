using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class UploadErrorLog
{
    public decimal ErrorLogId { get; set; }

    public decimal? UploadFileLogId { get; set; }

    public string? ErrorMessage { get; set; }
}
