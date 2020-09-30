// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// The value set to instantiate this attribute should be drawn from a terminologically robust code system that consists of or contains concepts to support describing the function a practitioner or organization may play in the immunization event. This value set is provided as a suggestive example.
  /// </summary>
  public static class ImmunizationFunctionCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AdministeringProvider = new Coding
    {
      Code = "AP",
      Display = "Administering Provider",
      System = "http://terminology.hl7.org/CodeSystem/v2-0443"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OrderingProvider = new Coding
    {
      Code = "OP",
      Display = "Ordering Provider",
      System = "http://terminology.hl7.org/CodeSystem/v2-0443"
    };
  };
}
