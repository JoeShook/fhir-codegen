// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// The possible types of variables for exposures or outcomes (E.g. Dichotomous, Continuous, Descriptive).
  /// </summary>
  public static class VariableTypeCodes
  {
    /// <summary>
    /// The variable is a continuous result such as a quantity.
    /// </summary>
    public static readonly Coding Continuous = new Coding
    {
      Code = "continuous",
      Display = "Continuous",
      System = "http://hl7.org/fhir/variable-type"
    };
    /// <summary>
    /// The variable is described narratively rather than quantitatively.
    /// </summary>
    public static readonly Coding Descriptive = new Coding
    {
      Code = "descriptive",
      Display = "Descriptive",
      System = "http://hl7.org/fhir/variable-type"
    };
    /// <summary>
    /// The variable is dichotomous, such as present or absent.
    /// </summary>
    public static readonly Coding Dichotomous = new Coding
    {
      Code = "dichotomous",
      Display = "Dichotomous",
      System = "http://hl7.org/fhir/variable-type"
    };
  };
}
