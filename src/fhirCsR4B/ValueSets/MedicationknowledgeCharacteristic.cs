// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// MedicationKnowledge Characteristic Codes
  /// </summary>
  public static class MedicationknowledgeCharacteristicCodes
  {
    /// <summary>
    /// Description of the coating of the product
    /// </summary>
    public static readonly Coding Coating = new Coding
    {
      Code = "coating",
      Display = "Coating",
      System = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic"
    };
    /// <summary>
    /// Description of the color of the product
    /// </summary>
    public static readonly Coding Color = new Coding
    {
      Code = "color",
      Display = "Color",
      System = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic"
    };
    /// <summary>
    /// Identyifying marks on product
    /// </summary>
    public static readonly Coding ImprintCode = new Coding
    {
      Code = "imprintcd",
      Display = "Imprint Code",
      System = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic"
    };
    /// <summary>
    /// Description of the Logo of the product
    /// </summary>
    public static readonly Coding Logo = new Coding
    {
      Code = "logo",
      Display = "Logo",
      System = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic"
    };
    /// <summary>
    /// Description of the scoring of the product
    /// </summary>
    public static readonly Coding Scoring = new Coding
    {
      Code = "scoring",
      Display = "Scoring",
      System = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic"
    };
    /// <summary>
    /// Description of the shape of the product
    /// </summary>
    public static readonly Coding Shape = new Coding
    {
      Code = "shape",
      Display = "Shape",
      System = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic"
    };
    /// <summary>
    /// Description of size of the product
    /// </summary>
    public static readonly Coding Size = new Coding
    {
      Code = "size",
      Display = "Size",
      System = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic"
    };

    /// <summary>
    /// Literal for code: Coating
    /// </summary>
    public const string LiteralCoating = "coating";

    /// <summary>
    /// Literal for code: MedicationknowledgeCharacteristicCoating
    /// </summary>
    public const string LiteralMedicationknowledgeCharacteristicCoating = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#coating";

    /// <summary>
    /// Literal for code: Color
    /// </summary>
    public const string LiteralColor = "color";

    /// <summary>
    /// Literal for code: MedicationknowledgeCharacteristicColor
    /// </summary>
    public const string LiteralMedicationknowledgeCharacteristicColor = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#color";

    /// <summary>
    /// Literal for code: ImprintCode
    /// </summary>
    public const string LiteralImprintCode = "imprintcd";

    /// <summary>
    /// Literal for code: MedicationknowledgeCharacteristicImprintCode
    /// </summary>
    public const string LiteralMedicationknowledgeCharacteristicImprintCode = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#imprintcd";

    /// <summary>
    /// Literal for code: Logo
    /// </summary>
    public const string LiteralLogo = "logo";

    /// <summary>
    /// Literal for code: MedicationknowledgeCharacteristicLogo
    /// </summary>
    public const string LiteralMedicationknowledgeCharacteristicLogo = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#logo";

    /// <summary>
    /// Literal for code: Scoring
    /// </summary>
    public const string LiteralScoring = "scoring";

    /// <summary>
    /// Literal for code: MedicationknowledgeCharacteristicScoring
    /// </summary>
    public const string LiteralMedicationknowledgeCharacteristicScoring = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#scoring";

    /// <summary>
    /// Literal for code: Shape
    /// </summary>
    public const string LiteralShape = "shape";

    /// <summary>
    /// Literal for code: MedicationknowledgeCharacteristicShape
    /// </summary>
    public const string LiteralMedicationknowledgeCharacteristicShape = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#shape";

    /// <summary>
    /// Literal for code: Size
    /// </summary>
    public const string LiteralSize = "size";

    /// <summary>
    /// Literal for code: MedicationknowledgeCharacteristicSize
    /// </summary>
    public const string LiteralMedicationknowledgeCharacteristicSize = "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#size";

    /// <summary>
    /// Dictionary for looking up MedicationknowledgeCharacteristic Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "coating", Coating }, 
      { "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#coating", Coating }, 
      { "color", Color }, 
      { "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#color", Color }, 
      { "imprintcd", ImprintCode }, 
      { "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#imprintcd", ImprintCode }, 
      { "logo", Logo }, 
      { "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#logo", Logo }, 
      { "scoring", Scoring }, 
      { "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#scoring", Scoring }, 
      { "shape", Shape }, 
      { "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#shape", Shape }, 
      { "size", Size }, 
      { "http://terminology.hl7.org/CodeSystem/medicationknowledge-characteristic#size", Size }, 
    };
  };
}