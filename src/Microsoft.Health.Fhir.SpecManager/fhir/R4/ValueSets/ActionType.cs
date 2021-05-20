// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The type of action to be performed.
  /// </summary>
  public static class ActionTypeCodes
  {
    /// <summary>
    /// The action is to create a new resource.
    /// </summary>
    public static readonly Coding Create = new Coding
    {
      Code = "create",
      Display = "Create",
      System = "http://terminology.hl7.org/CodeSystem/action-type"
    };
    /// <summary>
    /// The action is to fire a specific event.
    /// </summary>
    public static readonly Coding FireEvent = new Coding
    {
      Code = "fire-event",
      Display = "Fire Event",
      System = "http://terminology.hl7.org/CodeSystem/action-type"
    };
    /// <summary>
    /// The action is to remove an existing resource.
    /// </summary>
    public static readonly Coding Remove = new Coding
    {
      Code = "remove",
      Display = "Remove",
      System = "http://terminology.hl7.org/CodeSystem/action-type"
    };
    /// <summary>
    /// The action is to update an existing resource.
    /// </summary>
    public static readonly Coding Update = new Coding
    {
      Code = "update",
      Display = "Update",
      System = "http://terminology.hl7.org/CodeSystem/action-type"
    };
  };
}
