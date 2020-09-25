// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// A code specifying the types of information being requested.
  /// </summary>
  public static class EligibilityresponsePurposeCodes
  {
    /// <summary>
    /// The prior authorization requirements for the listed, or discovered if specified, converages for the categories of service and/or specifed biling codes are requested.
    /// </summary>
    public static readonly Coding CoverageAuthRequirements = new Coding
    {
      Code = "auth-requirements",
      Display = "Coverage auth-requirements",
      System = "http://hl7.org/fhir/eligibilityresponse-purpose"
    };
    /// <summary>
    /// The plan benefits and optionally benefits consumed  for the listed, or discovered if specified, converages are requested.
    /// </summary>
    public static readonly Coding CoverageBenefits = new Coding
    {
      Code = "benefits",
      Display = "Coverage benefits",
      System = "http://hl7.org/fhir/eligibilityresponse-purpose"
    };
    /// <summary>
    /// The insurer is requested to report on any coverages which they are aware of in addition to any specifed.
    /// </summary>
    public static readonly Coding CoverageDiscovery = new Coding
    {
      Code = "discovery",
      Display = "Coverage Discovery",
      System = "http://hl7.org/fhir/eligibilityresponse-purpose"
    };
    /// <summary>
    /// A check that the specified coverages are in-force is requested.
    /// </summary>
    public static readonly Coding CoverageValidation = new Coding
    {
      Code = "validation",
      Display = "Coverage Validation",
      System = "http://hl7.org/fhir/eligibilityresponse-purpose"
    };
  };
}
