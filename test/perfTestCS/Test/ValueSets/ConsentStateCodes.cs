// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Indicates the state of the consent.
  /// </summary>
  public static class ConsentStateCodesCodes
  {
    /// <summary>
    /// The consent is to be followed and enforced.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/consent-state-codes"
    };
    /// <summary>
    /// The consent is in development or awaiting use but is not yet intended to be acted upon.
    /// </summary>
    public static readonly Coding Pending = new Coding
    {
      Code = "draft",
      Display = "Pending",
      System = "http://hl7.org/fhir/consent-state-codes"
    };
    /// <summary>
    /// The consent was created wrongly (e.g. wrong patient) and should be ignored.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/consent-state-codes"
    };
    /// <summary>
    /// The consent is terminated or replaced.
    /// </summary>
    public static readonly Coding Inactive = new Coding
    {
      Code = "inactive",
      Display = "Inactive",
      System = "http://hl7.org/fhir/consent-state-codes"
    };
    /// <summary>
    /// The consent has been proposed but not yet agreed to by all parties. The negotiation stage.
    /// </summary>
    public static readonly Coding Proposed = new Coding
    {
      Code = "proposed",
      Display = "Proposed",
      System = "http://hl7.org/fhir/consent-state-codes"
    };
    /// <summary>
    /// The consent has been rejected by one or more of the parties.
    /// </summary>
    public static readonly Coding Rejected = new Coding
    {
      Code = "rejected",
      Display = "Rejected",
      System = "http://hl7.org/fhir/consent-state-codes"
    };
  };
}
