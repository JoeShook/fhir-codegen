// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Whether an operation parameter is an input or an output parameter.
  /// </summary>
  public static class OperationParameterUseCodes
  {
    /// <summary>
    /// This is an input parameter.
    /// </summary>
    public static readonly Coding In = new Coding
    {
      Code = "in",
      Display = "In",
      System = "http://hl7.org/fhir/operation-parameter-use"
    };
    /// <summary>
    /// This is an output parameter.
    /// </summary>
    public static readonly Coding Out = new Coding
    {
      Code = "out",
      Display = "Out",
      System = "http://hl7.org/fhir/operation-parameter-use"
    };
  };
}
