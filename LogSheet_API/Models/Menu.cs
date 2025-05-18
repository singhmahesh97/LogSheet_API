using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class Menu
{
    public decimal Id { get; set; }

    public string? Name { get; set; }

    public decimal? ParentMenuId { get; set; }

    public string? PageUrl { get; set; }

    public string? IsMenu { get; set; }

    public int? MenuOrder { get; set; }

    public string? ContentType { get; set; }

    public string? PageComp { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string? IsCheckerMaker { get; set; }

    public string? IsPublishDraft { get; set; }
}
