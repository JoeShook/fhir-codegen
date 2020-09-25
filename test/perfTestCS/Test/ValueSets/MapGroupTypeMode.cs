// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// If this is the default rule set to apply for the source type, or this combination of types.
  /// </summary>
  public static class MapGroupTypeModeCodes
  {
    /// <summary>
    /// This group is not a default group for the types.
    /// </summary>
    public static readonly Coding NotADefault = new Coding
    {
      Code = "none",
      Display = "Not a Default",
      System = "http://hl7.org/fhir/map-group-type-mode"
    };
    /// <summary>
    /// This group is a default mapping group for the specified types.
    /// </summary>
    public static readonly Coding DefaultForTypePlusCombination = new Coding
    {
      Code = "type-and-types",
      Display = "Default for type + combination",
      System = "http://hl7.org/fhir/map-group-type-mode"
    };
    /// <summary>
    /// This group is a default mapping group for the specified types and for the primary source type.
    /// </summary>
    public static readonly Coding DefaultForTypeCombination = new Coding
    {
      Code = "types",
      Display = "Default for Type Combination",
      System = "http://hl7.org/fhir/map-group-type-mode"
    };
  };
}
