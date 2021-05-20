// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The free/busy status of the slot.
  /// </summary>
  public static class SlotstatusCodes
  {
    /// <summary>
    /// Indicates that the time interval is busy because one  or more events have been scheduled for that interval.
    /// </summary>
    public static readonly Coding Busy = new Coding
    {
      Code = "busy",
      Display = "Busy",
      System = "http://hl7.org/fhir/slotstatus"
    };
    /// <summary>
    /// Indicates that the time interval is busy because one or more events have been tentatively scheduled for that interval.
    /// </summary>
    public static readonly Coding BusyTentative = new Coding
    {
      Code = "busy-tentative",
      Display = "Busy (Tentative)",
      System = "http://hl7.org/fhir/slotstatus"
    };
    /// <summary>
    /// Indicates that the time interval is busy and that the interval cannot be scheduled.
    /// </summary>
    public static readonly Coding BusyUnavailable = new Coding
    {
      Code = "busy-unavailable",
      Display = "Busy (Unavailable)",
      System = "http://hl7.org/fhir/slotstatus"
    };
    /// <summary>
    /// This instance should not have been part of this patient's medical record.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in error",
      System = "http://hl7.org/fhir/slotstatus"
    };
    /// <summary>
    /// Indicates that the time interval is free for scheduling.
    /// </summary>
    public static readonly Coding Free = new Coding
    {
      Code = "free",
      Display = "Free",
      System = "http://hl7.org/fhir/slotstatus"
    };
  };
}
