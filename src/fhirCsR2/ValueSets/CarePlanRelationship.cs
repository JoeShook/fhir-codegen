// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// Codes identifying the types of relationships between two plans.
  /// </summary>
  public static class CarePlanRelationshipCodes
  {
    /// <summary>
    /// This plan provides details about how to perform activities defined at a higher level by the referenced plan.
    /// </summary>
    public static readonly Coding Fulfills = new Coding
    {
      Code = "fulfills",
      Display = "Fulfills",
      System = "http://hl7.org/fhir/care-plan-relationship"
    };
    /// <summary>
    /// The referenced plan is considered to be part of this plan.
    /// </summary>
    public static readonly Coding Includes = new Coding
    {
      Code = "includes",
      Display = "Includes",
      System = "http://hl7.org/fhir/care-plan-relationship"
    };
    /// <summary>
    /// This plan takes the places of the referenced plan.
    /// </summary>
    public static readonly Coding Replaces = new Coding
    {
      Code = "replaces",
      Display = "Replaces",
      System = "http://hl7.org/fhir/care-plan-relationship"
    };

    /// <summary>
    /// Literal for code: Fulfills
    /// </summary>
    public const string LiteralFulfills = "fulfills";

    /// <summary>
    /// Literal for code: CarePlanRelationshipFulfills
    /// </summary>
    public const string LiteralCarePlanRelationshipFulfills = "http://hl7.org/fhir/care-plan-relationship#fulfills";

    /// <summary>
    /// Literal for code: Includes
    /// </summary>
    public const string LiteralIncludes = "includes";

    /// <summary>
    /// Literal for code: CarePlanRelationshipIncludes
    /// </summary>
    public const string LiteralCarePlanRelationshipIncludes = "http://hl7.org/fhir/care-plan-relationship#includes";

    /// <summary>
    /// Literal for code: Replaces
    /// </summary>
    public const string LiteralReplaces = "replaces";

    /// <summary>
    /// Literal for code: CarePlanRelationshipReplaces
    /// </summary>
    public const string LiteralCarePlanRelationshipReplaces = "http://hl7.org/fhir/care-plan-relationship#replaces";

    /// <summary>
    /// Dictionary for looking up CarePlanRelationship Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "fulfills", Fulfills }, 
      { "http://hl7.org/fhir/care-plan-relationship#fulfills", Fulfills }, 
      { "includes", Includes }, 
      { "http://hl7.org/fhir/care-plan-relationship#includes", Includes }, 
      { "replaces", Replaces }, 
      { "http://hl7.org/fhir/care-plan-relationship#replaces", Replaces }, 
    };
  };
}