using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class UploadFileRegisterAttribute
{
    public decimal Id { get; set; }

    public decimal? FileRegisterId { get; set; }

    public decimal? UserId { get; set; }

    public decimal? DependentId { get; set; }

    public string? OneTime_Execution { get; set; }

    public string? Daily_Execution { get; set; }

    public string? Weekly_Execution { get; set; }

    public string? Monthly_Execution { get; set; }
}
