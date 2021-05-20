// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The type of trigger.
  /// </summary>
  public static class TriggerTypeCodes
  {
    /// <summary>
    /// The trigger occurs whenever data of a particular type is accessed.
    /// </summary>
    public static readonly Coding DataAccessed = new Coding
    {
      Code = "data-accessed",
      Display = "Data Accessed",
      System = "http://hl7.org/fhir/trigger-type"
    };
    /// <summary>
    /// The trigger occurs whenever access to data of a particular type is completed.
    /// </summary>
    public static readonly Coding DataAccessEnded = new Coding
    {
      Code = "data-access-ended",
      Display = "Data Access Ended",
      System = "http://hl7.org/fhir/trigger-type"
    };
    /// <summary>
    /// The trigger occurs whenever data of a particular type is added.
    /// </summary>
    public static readonly Coding DataAdded = new Coding
    {
      Code = "data-added",
      Display = "Data Added",
      System = "http://hl7.org/fhir/trigger-type"
    };
    /// <summary>
    /// The trigger occurs whenever data of a particular type is changed in any way, either added, modified, or removed.
    /// </summary>
    public static readonly Coding DataChanged = new Coding
    {
      Code = "data-changed",
      Display = "Data Changed",
      System = "http://hl7.org/fhir/trigger-type"
    };
    /// <summary>
    /// The trigger occurs whenever data of a particular type is modified.
    /// </summary>
    public static readonly Coding DataUpdated = new Coding
    {
      Code = "data-modified",
      Display = "Data Updated",
      System = "http://hl7.org/fhir/trigger-type"
    };
    /// <summary>
    /// The trigger occurs whenever data of a particular type is removed.
    /// </summary>
    public static readonly Coding DataRemoved = new Coding
    {
      Code = "data-removed",
      Display = "Data Removed",
      System = "http://hl7.org/fhir/trigger-type"
    };
    /// <summary>
    /// The trigger occurs in response to a specific named event, and no other information about the trigger is specified. Named events are completely pre-coordinated, and the formal semantics of the trigger are not provided.
    /// </summary>
    public static readonly Coding NamedEvent = new Coding
    {
      Code = "named-event",
      Display = "Named Event",
      System = "http://hl7.org/fhir/trigger-type"
    };
    /// <summary>
    /// The trigger occurs at a specific time or periodically as described by a timing or schedule. A periodic event cannot have any data elements, but may have a name assigned as a shorthand for the event.
    /// </summary>
    public static readonly Coding Periodic = new Coding
    {
      Code = "periodic",
      Display = "Periodic",
      System = "http://hl7.org/fhir/trigger-type"
    };
  };
}
