using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class FAQsTagJoin
{
    public decimal Id { get; set; }

    public decimal? FAQId { get; set; }

    public decimal? ContentType { get; set; }

    public decimal? ContentTypePkId { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }
}
