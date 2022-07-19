// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This example value set defines a set of codes that can be used to indicate the specialty of a Practitioner.
  /// </summary>
  public static class PractitionerSpecialtyCodes
  {
    /// <summary>
    /// Cardiologist
    /// </summary>
    public static readonly Coding Cardiologist = new Coding
    {
      Code = "cardio",
      Display = "Cardiologist",
      System = "http://hl7.org/fhir/practitioner-specialty"
    };
    /// <summary>
    /// Dentist
    /// </summary>
    public static readonly Coding Dentist = new Coding
    {
      Code = "dent",
      Display = "Dentist",
      System = "http://hl7.org/fhir/practitioner-specialty"
    };
    /// <summary>
    /// Dietary consultant
    /// </summary>
    public static readonly Coding DietaryConsultant = new Coding
    {
      Code = "dietary",
      Display = "Dietary consultant",
      System = "http://hl7.org/fhir/practitioner-specialty"
    };
    /// <summary>
    /// Midwife
    /// </summary>
    public static readonly Coding Midwife = new Coding
    {
      Code = "midw",
      Display = "Midwife",
      System = "http://hl7.org/fhir/practitioner-specialty"
    };
    /// <summary>
    /// Systems architect
    /// </summary>
    public static readonly Coding SystemsArchitect = new Coding
    {
      Code = "sysarch",
      Display = "Systems architect",
      System = "http://hl7.org/fhir/practitioner-specialty"
    };

    /// <summary>
    /// Literal for code: Cardiologist
    /// </summary>
    public const string LiteralCardiologist = "cardio";

    /// <summary>
    /// Literal for code: PractitionerSpecialtyCardiologist
    /// </summary>
    public const string LiteralPractitionerSpecialtyCardiologist = "http://hl7.org/fhir/practitioner-specialty#cardio";

    /// <summary>
    /// Literal for code: Dentist
    /// </summary>
    public const string LiteralDentist = "dent";

    /// <summary>
    /// Literal for code: PractitionerSpecialtyDentist
    /// </summary>
    public const string LiteralPractitionerSpecialtyDentist = "http://hl7.org/fhir/practitioner-specialty#dent";

    /// <summary>
    /// Literal for code: DietaryConsultant
    /// </summary>
    public const string LiteralDietaryConsultant = "dietary";

    /// <summary>
    /// Literal for code: PractitionerSpecialtyDietaryConsultant
    /// </summary>
    public const string LiteralPractitionerSpecialtyDietaryConsultant = "http://hl7.org/fhir/practitioner-specialty#dietary";

    /// <summary>
    /// Literal for code: Midwife
    /// </summary>
    public const string LiteralMidwife = "midw";

    /// <summary>
    /// Literal for code: PractitionerSpecialtyMidwife
    /// </summary>
    public const string LiteralPractitionerSpecialtyMidwife = "http://hl7.org/fhir/practitioner-specialty#midw";

    /// <summary>
    /// Literal for code: SystemsArchitect
    /// </summary>
    public const string LiteralSystemsArchitect = "sysarch";

    /// <summary>
    /// Literal for code: PractitionerSpecialtySystemsArchitect
    /// </summary>
    public const string LiteralPractitionerSpecialtySystemsArchitect = "http://hl7.org/fhir/practitioner-specialty#sysarch";

    /// <summary>
    /// Dictionary for looking up PractitionerSpecialty Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "cardio", Cardiologist }, 
      { "http://hl7.org/fhir/practitioner-specialty#cardio", Cardiologist }, 
      { "dent", Dentist }, 
      { "http://hl7.org/fhir/practitioner-specialty#dent", Dentist }, 
      { "dietary", DietaryConsultant }, 
      { "http://hl7.org/fhir/practitioner-specialty#dietary", DietaryConsultant }, 
      { "midw", Midwife }, 
      { "http://hl7.org/fhir/practitioner-specialty#midw", Midwife }, 
      { "sysarch", SystemsArchitect }, 
      { "http://hl7.org/fhir/practitioner-specialty#sysarch", SystemsArchitect }, 
    };
  };
}