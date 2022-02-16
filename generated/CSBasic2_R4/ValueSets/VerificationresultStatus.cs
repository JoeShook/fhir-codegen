// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The validation status of the target
  /// </summary>
  public static class VerificationresultStatusCodes
  {
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding Attested = new Coding
    {
      Code = "attested",
      Display = "Attested",
      System = "http://hl7.org/fhir/CodeSystem/status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding InProcess = new Coding
    {
      Code = "in-process",
      Display = "In process",
      System = "http://hl7.org/fhir/CodeSystem/status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding RequiresRevalidation = new Coding
    {
      Code = "req-revalid",
      Display = "Requires revalidation",
      System = "http://hl7.org/fhir/CodeSystem/status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding ReValidationFailed = new Coding
    {
      Code = "reval-fail",
      Display = "Re-Validation failed",
      System = "http://hl7.org/fhir/CodeSystem/status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding ValidationFailed = new Coding
    {
      Code = "val-fail",
      Display = "Validation failed",
      System = "http://hl7.org/fhir/CodeSystem/status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding Validated = new Coding
    {
      Code = "validated",
      Display = "Validated",
      System = "http://hl7.org/fhir/CodeSystem/status"
    };
  };
}