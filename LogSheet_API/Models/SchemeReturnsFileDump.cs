using System;
using System.Collections.Generic;

namespace LogSheet_API.Models;

public partial class SchemeReturnsFileDump
{
    public decimal Id { get; set; }

    public string? Fundcode { get; set; }

    public string? SchemeName { get; set; }

    public string? PlanType { get; set; }

    public string? PrimaryBenchmark { get; set; }

    public string? AddnlBenchmark { get; set; }

    public string? Year1Return { get; set; }

    public string? Year1ReturnPrimaryBM { get; set; }

    public string? Year1ReturnAddnlBM { get; set; }

    public string? Year3Return { get; set; }

    public string? Year3ReturnPrimaryBM { get; set; }

    public string? Year3ReturnAddnlBM { get; set; }

    public string? Year5Return { get; set; }

    public string? Year5ReturnPrimaryBM { get; set; }

    public string? Year5ReturnAddnlBM { get; set; }

    public string? InceptionReturn { get; set; }

    public string? InceptionReturnPrimaryBM { get; set; }

    public string? InceptionReturnAddnlBM { get; set; }

    public string? Year1Scheme10KValue { get; set; }

    public string? Year1PrimaryBM10KValue { get; set; }

    public string? Year1AddnlBM10KValue { get; set; }

    public string? Year3Scheme10KValue { get; set; }

    public string? Year3PrimaryBM10KValue { get; set; }

    public string? Year3AddnlBM10KValue { get; set; }

    public string? Year5Scheme10KValue { get; set; }

    public string? Year5PrimaryBM10KValue { get; set; }

    public string? Year5AddnlBM10KValue { get; set; }

    public string? InceptionScheme10KValue { get; set; }

    public string? InceptionPrimaryBM10KValue { get; set; }

    public string? InceptionAddnlBM10KValue { get; set; }

    public string? Disclaimer { get; set; }
}
