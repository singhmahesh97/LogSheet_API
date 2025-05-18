using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class MST011
{
    public decimal EndPointId { get; set; }

    public string? SystemCode { get; set; }

    public string? DisplayName { get; set; }

    public decimal? EndPointTypeId { get; set; }

    public string? URL { get; set; }

    public string? MenuKey { get; set; }

    public string? MenuIcon { get; set; }

    public decimal? MenuOrder { get; set; }

    public decimal? ParentEndPointId { get; set; }

    public string? DisplayEndPoint { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateOnly? LastModifiedDate { get; set; }

    public string? Active { get; set; }
}
