// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// The intended usage for supplemental data elements in the measure.
  /// </summary>
  public static class MeasureDataUsageCodes
  {
    /// <summary>
    /// The data is intended to be used to calculate and apply a risk adjustment model for the measure.
    /// </summary>
    public static readonly Coding RiskAdjustmentFactor = new Coding
    {
      Code = "risk-adjustment-factor",
      Display = "Risk Adjustment Factor",
      System = "http://terminology.hl7.org/CodeSystem/measure-data-usage"
    };
    /// <summary>
    /// The data is intended to be provided as additional information alongside the measure results.
    /// </summary>
    public static readonly Coding SupplementalData = new Coding
    {
      Code = "supplemental-data",
      Display = "Supplemental Data",
      System = "http://terminology.hl7.org/CodeSystem/measure-data-usage"
    };
  };
}
