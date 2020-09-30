// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
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
  };
}
