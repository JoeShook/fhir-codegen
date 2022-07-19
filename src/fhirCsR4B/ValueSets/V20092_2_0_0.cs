// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Value Set of codes which are used to specify that a patient is being re-admitted to a healthcare facility from which they were discharged, and indicates the circumstances around such re-admission.
  /// </summary>
  public static class V20092Codes
  {
    /// <summary>
    /// Re-admission
    /// </summary>
    public static readonly Coding ReAdmission = new Coding
    {
      Code = "R",
      Display = "Re-admission",
      System = "http://terminology.hl7.org/CodeSystem/v2-0092"
    };

    /// <summary>
    /// Literal for code: ReAdmission
    /// </summary>
    public const string LiteralReAdmission = "R";

    /// <summary>
    /// Literal for code: V20092ReAdmission
    /// </summary>
    public const string LiteralV20092ReAdmission = "http://terminology.hl7.org/CodeSystem/v2-0092#R";

    /// <summary>
    /// Dictionary for looking up V20092 Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "R", ReAdmission }, 
      { "http://terminology.hl7.org/CodeSystem/v2-0092#R", ReAdmission }, 
    };
  };
}