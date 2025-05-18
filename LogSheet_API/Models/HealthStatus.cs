using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class HealthStatus
{
    public byte HealthStatusId { get; set; }

    public string AgentName { get; set; } = null!;

    public DateTime? LastHeartbeat { get; set; }

    public string? ApplicationName { get; set; }

    public string? Active { get; set; }

    public DateTime? LastReminderSentOn { get; set; }

    public string? AgentType { get; set; }

    public string? AgentAbsolutePath { get; set; }

    public string? PreClosure { get; set; }

    public string? PostClosure { get; set; }

    public DateTime? NextScheduledRestart { get; set; }

    public string? additionalStats { get; set; }
}
