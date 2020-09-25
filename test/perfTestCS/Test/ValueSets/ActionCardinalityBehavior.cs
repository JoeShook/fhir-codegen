// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Defines behavior for an action or a group for how many times that item may be repeated.
  /// </summary>
  public static class ActionCardinalityBehaviorCodes
  {
    /// <summary>
    /// The action may be selected multiple times.
    /// </summary>
    public static readonly Coding Multiple = new Coding
    {
      Code = "multiple",
      Display = "Multiple",
      System = "http://hl7.org/fhir/action-cardinality-behavior"
    };
    /// <summary>
    /// The action may only be selected one time.
    /// </summary>
    public static readonly Coding Single = new Coding
    {
      Code = "single",
      Display = "Single",
      System = "http://hl7.org/fhir/action-cardinality-behavior"
    };
  };
}
