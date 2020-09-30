// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// The current state of the list.
  /// </summary>
  public static class ListStatusCodes
  {
    /// <summary>
    /// The list is considered to be an active part of the patient's record.
    /// </summary>
    public static readonly Coding Current = new Coding
    {
      Code = "current",
      Display = "Current",
      System = "http://hl7.org/fhir/list-status"
    };
    /// <summary>
    /// The list was never accurate.  It is retained for medico-legal purposes only.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered In Error",
      System = "http://hl7.org/fhir/list-status"
    };
    /// <summary>
    /// The list is "old" and should no longer be considered accurate or relevant.
    /// </summary>
    public static readonly Coding Retired = new Coding
    {
      Code = "retired",
      Display = "Retired",
      System = "http://hl7.org/fhir/list-status"
    };
  };
}
