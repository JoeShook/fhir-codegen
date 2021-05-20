// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// What Search Comparator Codes are supported in search.
  /// </summary>
  public static class SearchComparatorCodes
  {
    /// <summary>
    /// the value for the parameter in the resource is approximately the same to the provided value.
    /// </summary>
    public static readonly Coding Approximately = new Coding
    {
      Code = "ap",
      Display = "Approximately",
      System = "http://hl7.org/fhir/search-comparator"
    };
    /// <summary>
    /// the value for the parameter in the resource ends before the provided value.
    /// </summary>
    public static readonly Coding EndsBefore = new Coding
    {
      Code = "eb",
      Display = "Ends Before",
      System = "http://hl7.org/fhir/search-comparator"
    };
    /// <summary>
    /// the value for the parameter in the resource is equal to the provided value.
    /// </summary>
    public static readonly new Coding Equals = new Coding
    {
      Code = "eq",
      Display = "Equals",
      System = "http://hl7.org/fhir/search-comparator"
    };
    /// <summary>
    /// the value for the parameter in the resource is greater or equal to the provided value.
    /// </summary>
    public static readonly Coding GreaterOrEquals = new Coding
    {
      Code = "ge",
      Display = "Greater or Equals",
      System = "http://hl7.org/fhir/search-comparator"
    };
    /// <summary>
    /// the value for the parameter in the resource is greater than the provided value.
    /// </summary>
    public static readonly Coding GreaterThan = new Coding
    {
      Code = "gt",
      Display = "Greater Than",
      System = "http://hl7.org/fhir/search-comparator"
    };
    /// <summary>
    /// the value for the parameter in the resource is less or equal to the provided value.
    /// </summary>
    public static readonly Coding LessOfEqual = new Coding
    {
      Code = "le",
      Display = "Less of Equal",
      System = "http://hl7.org/fhir/search-comparator"
    };
    /// <summary>
    /// the value for the parameter in the resource is less than the provided value.
    /// </summary>
    public static readonly Coding LessThan = new Coding
    {
      Code = "lt",
      Display = "Less Than",
      System = "http://hl7.org/fhir/search-comparator"
    };
    /// <summary>
    /// the value for the parameter in the resource is not equal to the provided value.
    /// </summary>
    public static readonly Coding NotEquals = new Coding
    {
      Code = "ne",
      Display = "Not Equals",
      System = "http://hl7.org/fhir/search-comparator"
    };
    /// <summary>
    /// the value for the parameter in the resource starts after the provided value.
    /// </summary>
    public static readonly Coding StartsAfter = new Coding
    {
      Code = "sa",
      Display = "Starts After",
      System = "http://hl7.org/fhir/search-comparator"
    };
  };
}
