// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The workflow/clinical status of the composition.
  /// </summary>
  public static class CompositionStatusCodes
  {
    /// <summary>
    /// The composition content or the referenced resources have been modified (edited or added to) subsequent to being released as "final" and the composition is complete and verified by an authorized person.
    /// </summary>
    public static readonly Coding Amended = new Coding
    {
      Code = "amended",
      Display = "Amended",
      System = "http://hl7.org/fhir/composition-status"
    };
    /// <summary>
    /// This composition has been withdrawn or superseded and should no longer be used.
    /// </summary>
    public static readonly Coding Deprecated = new Coding
    {
      Code = "deprecated",
      Display = "Deprecated",
      System = "http://hl7.org/fhir/composition-status"
    };
    /// <summary>
    /// The composition or document was originally created/issued in error, and this is an amendment that marks that the entire series should not be considered as valid.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/composition-status"
    };
    /// <summary>
    /// This version of the composition is complete and verified by an appropriate person and no further work is planned. Any subsequent updates would be on a new version of the composition.
    /// </summary>
    public static readonly Coding Final = new Coding
    {
      Code = "final",
      Display = "Final",
      System = "http://hl7.org/fhir/composition-status"
    };
    /// <summary>
    /// This is a preliminary composition or document (also known as initial or interim). The content may be incomplete or unverified.
    /// </summary>
    public static readonly Coding Preliminary = new Coding
    {
      Code = "preliminary",
      Display = "Preliminary",
      System = "http://hl7.org/fhir/composition-status"
    };

    /// <summary>
    /// Literal for code: Amended
    /// </summary>
    public const string LiteralAmended = "amended";

    /// <summary>
    /// Literal for code: CompositionStatusAmended
    /// </summary>
    public const string LiteralCompositionStatusAmended = "http://hl7.org/fhir/composition-status#amended";

    /// <summary>
    /// Literal for code: Deprecated
    /// </summary>
    public const string LiteralDeprecated = "deprecated";

    /// <summary>
    /// Literal for code: CompositionStatusDeprecated
    /// </summary>
    public const string LiteralCompositionStatusDeprecated = "http://hl7.org/fhir/composition-status#deprecated";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: CompositionStatusEnteredInError
    /// </summary>
    public const string LiteralCompositionStatusEnteredInError = "http://hl7.org/fhir/composition-status#entered-in-error";

    /// <summary>
    /// Literal for code: Final
    /// </summary>
    public const string LiteralFinal = "final";

    /// <summary>
    /// Literal for code: CompositionStatusFinal
    /// </summary>
    public const string LiteralCompositionStatusFinal = "http://hl7.org/fhir/composition-status#final";

    /// <summary>
    /// Literal for code: Preliminary
    /// </summary>
    public const string LiteralPreliminary = "preliminary";

    /// <summary>
    /// Literal for code: CompositionStatusPreliminary
    /// </summary>
    public const string LiteralCompositionStatusPreliminary = "http://hl7.org/fhir/composition-status#preliminary";

    /// <summary>
    /// Dictionary for looking up CompositionStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "amended", Amended }, 
      { "http://hl7.org/fhir/composition-status#amended", Amended }, 
      { "deprecated", Deprecated }, 
      { "http://hl7.org/fhir/composition-status#deprecated", Deprecated }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/composition-status#entered-in-error", EnteredInError }, 
      { "final", Final }, 
      { "http://hl7.org/fhir/composition-status#final", Final }, 
      { "preliminary", Preliminary }, 
      { "http://hl7.org/fhir/composition-status#preliminary", Preliminary }, 
    };
  };
}