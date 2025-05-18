using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MailInbox
{
    public int MailInboxId { get; set; }

    public int? AppId { get; set; }

    public string? MailToId { get; set; }

    public string? MailFromId { get; set; }

    public string? MailFromName { get; set; }

    public string? MailCCId { get; set; }

    public string? MailCCName { get; set; }

    public DateTime? MailDate { get; set; }

    public string? MailSubject { get; set; }

    public DateTime? MailReceivedDate { get; set; }

    public string? IsMailHTML { get; set; }

    public string? MailBodyText { get; set; }

    public string? MailBodyHTML { get; set; }

    public string? MailAttachments { get; set; }

    public string? MailAttachmentsActual { get; set; }

    public string? MailEmbeddedFiles { get; set; }

    public string? MailEmbeddedFilesActual { get; set; }

    public string Status { get; set; } = null!;

    public string RouterName { get; set; } = null!;

    public byte? AttemptsCount { get; set; }

    public DateTime? LastAttempt { get; set; }

    public string? ErrorLog { get; set; }
}
