using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class UploadFileRegister
{
    public decimal FileRegisterId { get; set; }

    public string UploadType { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public string? PendingForApproval { get; set; }

    public decimal? ApprovedBy { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime? CompletionDataTime { get; set; }

    public string? ScheduledDateTime { get; set; }

    public decimal? ParentFileRegisterId { get; set; }

    public decimal? TotalRecords { get; set; }

    public decimal? ErrorRecords { get; set; }

    public decimal? ValidRecords { get; set; }

    public string? ErrorLog { get; set; }

    public string? TableName { get; set; }

    public string? CleanupCommand { get; set; }

    public string? InputOutputFlag { get; set; }

    public DateTime? CompletionDateTime { get; set; }

    public decimal? DuplicateRecords { get; set; }
}
