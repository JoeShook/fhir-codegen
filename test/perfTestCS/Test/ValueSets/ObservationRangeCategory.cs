// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Codes identifying the category of observation range.
  /// </summary>
  public static class ObservationRangeCategoryCodes
  {
    /// <summary>
    /// Absolute Range for Ordinal and Continuous Observations. Results outside this range are not possible.
    /// </summary>
    public static readonly Coding AbsoluteRange = new Coding
    {
      Code = "absolute",
      Display = "absolute range",
      System = "http://hl7.org/fhir/observation-range-category"
    };
    /// <summary>
    /// Critical Range for Ordinal and Continuous Observations.
    /// </summary>
    public static readonly Coding CriticalRange = new Coding
    {
      Code = "critical",
      Display = "critical range",
      System = "http://hl7.org/fhir/observation-range-category"
    };
    /// <summary>
    /// Reference (Normal) Range for Ordinal and Continuous Observations.
    /// </summary>
    public static readonly Coding ReferenceRange = new Coding
    {
      Code = "reference",
      Display = "reference range",
      System = "http://hl7.org/fhir/observation-range-category"
    };
  };
}
