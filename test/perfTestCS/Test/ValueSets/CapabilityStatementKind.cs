// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// How a capability statement is intended to be used.
  /// </summary>
  public static class CapabilityStatementKindCodes
  {
    /// <summary>
    /// The CapabilityStatement instance represents the capabilities of a system or piece of software, independent of a particular installation.
    /// </summary>
    public static readonly Coding Capability = new Coding
    {
      Code = "capability",
      Display = "Capability",
      System = "http://hl7.org/fhir/capability-statement-kind"
    };
    /// <summary>
    /// The CapabilityStatement instance represents the present capabilities of a specific system instance.  This is the kind returned by /metadata for a FHIR server end-point.
    /// </summary>
    public static readonly Coding Instance = new Coding
    {
      Code = "instance",
      Display = "Instance",
      System = "http://hl7.org/fhir/capability-statement-kind"
    };
    /// <summary>
    /// The CapabilityStatement instance represents a set of requirements for other systems to meet; e.g. as part of an implementation guide or 'request for proposal'.
    /// </summary>
    public static readonly Coding Requirements = new Coding
    {
      Code = "requirements",
      Display = "Requirements",
      System = "http://hl7.org/fhir/capability-statement-kind"
    };
  };
}
