// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// A code that indicates how the server supports conditional delete.
  /// </summary>
  public static class ConditionalDeleteStatusCodes
  {
    /// <summary>
    /// Conditional deletes are supported, and multiple resources can be deleted in a single interaction.
    /// </summary>
    public static readonly Coding MultipleDeletesSupported = new Coding
    {
      Code = "multiple",
      Display = "Multiple Deletes Supported",
      System = "http://hl7.org/fhir/conditional-delete-status"
    };
    /// <summary>
    /// No support for conditional deletes.
    /// </summary>
    public static readonly Coding NotSupported = new Coding
    {
      Code = "not-supported",
      Display = "Not Supported",
      System = "http://hl7.org/fhir/conditional-delete-status"
    };
    /// <summary>
    /// Conditional deletes are supported, but only single resources at a time.
    /// </summary>
    public static readonly Coding SingleDeletesSupported = new Coding
    {
      Code = "single",
      Display = "Single Deletes Supported",
      System = "http://hl7.org/fhir/conditional-delete-status"
    };
  };
}
