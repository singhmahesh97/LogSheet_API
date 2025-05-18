using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MAILTABLE
{
    public int MAILID { get; set; }

    public DateTime MAILDATE { get; set; }

    public decimal? PICKDATE { get; set; }

    public string? SENDERNAME { get; set; }

    public string? SENDERADDRESS { get; set; }

    public string? RECIPIENTNAME { get; set; }

    public string? RECIPIENTADDRESS { get; set; }

    public string? CCNAME { get; set; }

    public string? CCADDRESS { get; set; }

    public string? BCCNAME { get; set; }

    public string? BCCADDRESS { get; set; }

    public string? SUBJECT { get; set; }

    public string? MESSAGE { get; set; }

    public string? DELSRAURL { get; set; }

    public string? ATTACHMENT { get; set; }

    public string? STATUS { get; set; }

    public DateTime? SENTDATETIME { get; set; }

    public decimal CREATEDBY { get; set; }

    public DateTime CREATEDDATE { get; set; }

    public DateTime? ENDDATE { get; set; }

    public string? ATTACHMENTFORMAT { get; set; }

    public decimal? PICKTIME { get; set; }

    public string? FAILEDADDRESS { get; set; }
}
