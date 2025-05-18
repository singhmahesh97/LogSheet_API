using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class audit_CapitalLine_SchemeMaster
{
    public decimal SchemeMasterId { get; set; }

    public decimal? FileId { get; set; }

    public DateTime? DateAndTime { get; set; }

    public string? mf_cocode { get; set; }

    public string? amficode { get; set; }

    public string? mf_schcode { get; set; }

    public string? ClassCode { get; set; }

    public string? Category { get; set; }

    public string? sch_name { get; set; }

    public string? navrs { get; set; }

    public string? navdate { get; set; }

    public string? rtcode { get; set; }

    public string? isin { get; set; }

    public string? isin_Reinvestment { get; set; }

    public string? FundManager { get; set; }

    public string? LaunchDate { get; set; }

    public string? MinInvestment { get; set; }

    public string? IncrementalInvestment { get; set; }

    public string? MinInvestment_SIP { get; set; }

    public string? frequency { get; set; }

    public string? SchemeAUM { get; set; }

    public string? EntrytLoad { get; set; }

    public string? ExitLoad { get; set; }

    public string? FundType { get; set; }

    public string? InvestmentType { get; set; }

    public string? MCAPCategory { get; set; }

    public string? BMCode { get; set; }

    public string? BenchmarkName { get; set; }

    public string? riskometervalue { get; set; }

    public string? SchemeInvestmentType { get; set; }

    public string? SchemeType { get; set; }

    public string? expense_ratio { get; set; }

    public string? exit_load_flag { get; set; }

    public string? lock_in_period { get; set; }

    public string? lock_in_period_flag { get; set; }

    public string? dividend_reinvestment_flag { get; set; }

    public string? purchase_allowed { get; set; }

    public string? sip_flag { get; set; }

    public string? maximum_purchase_amount { get; set; }

    public string? FundManager_JoiningDate { get; set; }

    public string? minimum_redemption_qty { get; set; }

    public string? redemption_allowed { get; set; }

    public string? stp_flag { get; set; }

    public string? swp_flag { get; set; }

    public string? redemption_amt_minimum { get; set; }

    public string? redemption_amt_multiple { get; set; }

    public string? SchemeName_AMFIReported { get; set; }

    public string? taxation_type { get; set; }

    public string? swp_mininstallmentnumber { get; set; }
}
