// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Whether the effect estimate is an absolute effect estimate (absolute difference) or a relative effect estimate (relative difference), and the specific type of effect estimate (eg relative risk or median difference).
  /// </summary>
  public static class EffectEstimateTypeCodes
  {
    /// <summary>
    /// absolute risk difference (a type of absolute effect estimate).
    /// </summary>
    public static readonly Coding AbsoluteRiskDifference = new Coding
    {
      Code = "absolute-ARD",
      Display = "absolute risk difference",
      System = "http://terminology.hl7.org/CodeSystem/effect-estimate-type"
    };
    /// <summary>
    /// mean difference (a type of absolute effect estimate).
    /// </summary>
    public static readonly Coding MeanDifference = new Coding
    {
      Code = "absolute-MeanDiff",
      Display = "mean difference",
      System = "http://terminology.hl7.org/CodeSystem/effect-estimate-type"
    };
    /// <summary>
    /// median difference (a type of absolute effect estimate).
    /// </summary>
    public static readonly Coding MedianDifference = new Coding
    {
      Code = "absolute-MedianDiff",
      Display = "median difference",
      System = "http://terminology.hl7.org/CodeSystem/effect-estimate-type"
    };
    /// <summary>
    /// standardized mean difference (a type of absolute effect estimate).
    /// </summary>
    public static readonly Coding StandardizedMeanDifference = new Coding
    {
      Code = "absolute-SMD",
      Display = "standardized mean difference",
      System = "http://terminology.hl7.org/CodeSystem/effect-estimate-type"
    };
    /// <summary>
    /// hazard ratio (a type of relative effect estimate).
    /// </summary>
    public static readonly Coding HazardRatio = new Coding
    {
      Code = "relative-HR",
      Display = "hazard ratio",
      System = "http://terminology.hl7.org/CodeSystem/effect-estimate-type"
    };
    /// <summary>
    /// odds ratio (a type of relative effect estimate).
    /// </summary>
    public static readonly Coding OddsRatio = new Coding
    {
      Code = "relative-OR",
      Display = "odds ratio",
      System = "http://terminology.hl7.org/CodeSystem/effect-estimate-type"
    };
    /// <summary>
    /// relative risk (a type of relative effect estimate).
    /// </summary>
    public static readonly Coding RelativeRisk = new Coding
    {
      Code = "relative-RR",
      Display = "relative risk",
      System = "http://terminology.hl7.org/CodeSystem/effect-estimate-type"
    };
  };
}
