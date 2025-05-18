using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class ProductsBK26
{
    public decimal ID { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public decimal? SchemeCategoryId { get; set; }

    public string? PublishStatus { get; set; }

    public string? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public decimal? UnderEditBy { get; set; }

    public string? slug { get; set; }

    public string? InvestmentHorizon { get; set; }

    public string? InvestmentObjective { get; set; }

    public string? InvestmentStyle { get; set; }

    public string? SIPAvailability { get; set; }

    public string? AUM { get; set; }

    public string? Risk { get; set; }

    public string? ExpenseRatio { get; set; }

    public string? ExitLoad { get; set; }

    public string? FundSize { get; set; }

    public string? ReturnPA { get; set; }

    public string? NAV { get; set; }

    public DateTime? RegularInception { get; set; }

    public DateTime? DirectInception { get; set; }

    public string? schcode { get; set; }

    public string? DBSchemeCode { get; set; }

    public string? SCBSchemeCode { get; set; }

    public string? EntryLoadText { get; set; }

    public string? ExitLoadText { get; set; }

    public string? InvestmentObjectiveCard { get; set; }

    public string? InvestmentHorizonCard { get; set; }

    public decimal? CoverImage { get; set; }

    public string? FundInFocus { get; set; }

    public decimal? FileRegisterId { get; set; }

    public string? ProductLabel { get; set; }
}
