// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Whether the application produces or consumes documents.
  /// </summary>
  public static class DocumentModeCodes
  {
    /// <summary>
    /// The application consumes documents of the specified type.
    /// </summary>
    public static readonly Coding Consumer = new Coding
    {
      Code = "consumer",
      Display = "Consumer",
      System = "http://hl7.org/fhir/document-mode"
    };
    /// <summary>
    /// The application produces documents of the specified type.
    /// </summary>
    public static readonly Coding Producer = new Coding
    {
      Code = "producer",
      Display = "Producer",
      System = "http://hl7.org/fhir/document-mode"
    };
  };
}
