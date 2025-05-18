using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class FileRegisterOld
{
    public decimal FileRegisterId { get; set; }

    public int? FileTypeId { get; set; }

    public string FileUrl { get; set; } = null!;

    public string FileDisplayName { get; set; } = null!;

    public string FileStatus { get; set; } = null!;

    public decimal? DelsraFileId { get; set; }

    public string? DownloadPath { get; set; }

    public int? TotalRecords { get; set; }

    public int? ValidRecords { get; set; }

    public int? ErroneousRecords { get; set; }

    public int? DuplicateRecord { get; set; }

    public string? CleanupTableName { get; set; }

    public string? CleanupCommand { get; set; }

    public string? CleanupParams { get; set; }

    public string? UploadErrorLog { get; set; }

    public string MarkedForDelete { get; set; } = null!;

    public int? CheckerLotId { get; set; }

    public string CheckerStatus { get; set; } = null!;

    public decimal? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime LastModifiedDate { get; set; }
}
