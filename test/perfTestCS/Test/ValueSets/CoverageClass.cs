// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// This value set includes Coverage Class codes.
  /// </summary>
  public static class CoverageClassCodes
  {
    /// <summary>
    /// A class of benefits.
    /// </summary>
    public static readonly Coding Class = new Coding
    {
      Code = "class",
      Display = "Class",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// An employee group
    /// </summary>
    public static readonly Coding Group = new Coding
    {
      Code = "group",
      Display = "Group",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A specific suite of benefits.
    /// </summary>
    public static readonly Coding Plan = new Coding
    {
      Code = "plan",
      Display = "Plan",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// Pharmacy benefit manager's Business Identification Number.
    /// </summary>
    public static readonly Coding RXBIN = new Coding
    {
      Code = "rxbin",
      Display = "RX BIN",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A Pharmacy Benefit Manager specified Group number.
    /// </summary>
    public static readonly Coding RXGroup = new Coding
    {
      Code = "rxgroup",
      Display = "RX Group",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A Pharmacy Benefit Manager specified Member ID.
    /// </summary>
    public static readonly Coding RXId = new Coding
    {
      Code = "rxid",
      Display = "RX Id",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A Pharmacy Benefit Manager specified Processor Control Number.
    /// </summary>
    public static readonly Coding RXPCN = new Coding
    {
      Code = "rxpcn",
      Display = "RX PCN",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A sequence number associated with a short-term continuance of the coverage.
    /// </summary>
    public static readonly Coding Sequence = new Coding
    {
      Code = "sequence",
      Display = "Sequence",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A subset of a class of benefits.
    /// </summary>
    public static readonly Coding SubClass = new Coding
    {
      Code = "subclass",
      Display = "SubClass",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A sub-group of an employee group
    /// </summary>
    public static readonly Coding SubGroup = new Coding
    {
      Code = "subgroup",
      Display = "SubGroup",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
    /// <summary>
    /// A subset of a specific suite of benefits.
    /// </summary>
    public static readonly Coding SubPlan = new Coding
    {
      Code = "subplan",
      Display = "SubPlan",
      System = "http://terminology.hl7.org/CodeSystem/coverage-class"
    };
  };
}
