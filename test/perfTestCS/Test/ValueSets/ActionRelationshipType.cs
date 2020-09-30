// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Defines the types of relationships between actions.
  /// </summary>
  public static class ActionRelationshipTypeCodes
  {
    /// <summary>
    /// The action must be performed after the related action.
    /// </summary>
    public static readonly Coding After = new Coding
    {
      Code = "after",
      Display = "After",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed after the end of the related action.
    /// </summary>
    public static readonly Coding AfterEnd = new Coding
    {
      Code = "after-end",
      Display = "After End",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed after the start of the related action.
    /// </summary>
    public static readonly Coding AfterStart = new Coding
    {
      Code = "after-start",
      Display = "After Start",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed before the related action.
    /// </summary>
    public static readonly Coding Before = new Coding
    {
      Code = "before",
      Display = "Before",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed before the end of the related action.
    /// </summary>
    public static readonly Coding BeforeEnd = new Coding
    {
      Code = "before-end",
      Display = "Before End",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed before the start of the related action.
    /// </summary>
    public static readonly Coding BeforeStart = new Coding
    {
      Code = "before-start",
      Display = "Before Start",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed concurrent with the related action.
    /// </summary>
    public static readonly Coding Concurrent = new Coding
    {
      Code = "concurrent",
      Display = "Concurrent",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed concurrent with the end of the related action.
    /// </summary>
    public static readonly Coding ConcurrentWithEnd = new Coding
    {
      Code = "concurrent-with-end",
      Display = "Concurrent With End",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed concurrent with the start of the related action.
    /// </summary>
    public static readonly Coding ConcurrentWithStart = new Coding
    {
      Code = "concurrent-with-start",
      Display = "Concurrent With Start",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
  };
}
