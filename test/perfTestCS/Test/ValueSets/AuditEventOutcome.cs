// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Indicates whether the event succeeded or failed.
  /// </summary>
  public static class AuditEventOutcomeCodes
  {
    /// <summary>
    /// The operation completed successfully (whether with warnings or not).
    /// </summary>
    public static readonly Coding Success = new Coding
    {
      Code = "0",
      Display = "Success",
      System = "http://hl7.org/fhir/audit-event-outcome"
    };
    /// <summary>
    /// An error of such magnitude occurred that the system is no longer available for use (i.e. the system died).
    /// </summary>
    public static readonly Coding MajorFailure = new Coding
    {
      Code = "12",
      Display = "Major failure",
      System = "http://hl7.org/fhir/audit-event-outcome"
    };
    /// <summary>
    /// The action was not successful due to some kind of minor failure (often equivalent to an HTTP 400 response).
    /// </summary>
    public static readonly Coding MinorFailure = new Coding
    {
      Code = "4",
      Display = "Minor failure",
      System = "http://hl7.org/fhir/audit-event-outcome"
    };
    /// <summary>
    /// The action was not successful due to some kind of unexpected error (often equivalent to an HTTP 500 response).
    /// </summary>
    public static readonly Coding SeriousFailure = new Coding
    {
      Code = "8",
      Display = "Serious failure",
      System = "http://hl7.org/fhir/audit-event-outcome"
    };
  };
}
