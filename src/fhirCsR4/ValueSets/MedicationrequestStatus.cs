// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// MedicationRequest Status Codes
  /// </summary>
  public static class MedicationrequestStatusCodes
  {
    /// <summary>
    /// The prescription is 'actionable', but not all actions that are implied by it have occurred yet.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/CodeSystem/medicationrequest-status"
    };
    /// <summary>
    /// The prescription has been withdrawn before any administrations have occurred
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "cancelled",
      Display = "Cancelled",
      System = "http://hl7.org/fhir/CodeSystem/medicationrequest-status"
    };
    /// <summary>
    /// All actions that are implied by the prescription have occurred.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/CodeSystem/medicationrequest-status"
    };
    /// <summary>
    /// The prescription is not yet 'actionable', e.g. it is a work in progress, requires sign-off, verification or needs to be run through decision support process.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "Draft",
      System = "http://hl7.org/fhir/CodeSystem/medicationrequest-status"
    };
    /// <summary>
    /// Some of the actions that are implied by the medication request may have occurred.  For example, the medication may have been dispensed and the patient may have taken some of the medication.  Clinical decision support systems should take this status into account
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/CodeSystem/medicationrequest-status"
    };
    /// <summary>
    /// Actions implied by the prescription are to be temporarily halted, but are expected to continue later.  May also be called 'suspended'.
    /// </summary>
    public static readonly Coding OnHold = new Coding
    {
      Code = "on-hold",
      Display = "On Hold",
      System = "http://hl7.org/fhir/CodeSystem/medicationrequest-status"
    };
    /// <summary>
    /// Actions implied by the prescription are to be permanently halted, before all of the administrations occurred. This should not be used if the original order was entered in error
    /// </summary>
    public static readonly Coding Stopped = new Coding
    {
      Code = "stopped",
      Display = "Stopped",
      System = "http://hl7.org/fhir/CodeSystem/medicationrequest-status"
    };
    /// <summary>
    /// The authoring/source system does not know which of the status values currently applies for this observation. Note: This concept is not to be used for 'other' - one of the listed statuses is presumed to apply, but the authoring/source system does not know which.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/CodeSystem/medicationrequest-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: MedicationrequestStatusActive
    /// </summary>
    public const string LiteralMedicationrequestStatusActive = "http://hl7.org/fhir/CodeSystem/medicationrequest-status#active";

    /// <summary>
    /// Literal for code: Cancelled
    /// </summary>
    public const string LiteralCancelled = "cancelled";

    /// <summary>
    /// Literal for code: MedicationrequestStatusCancelled
    /// </summary>
    public const string LiteralMedicationrequestStatusCancelled = "http://hl7.org/fhir/CodeSystem/medicationrequest-status#cancelled";

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "completed";

    /// <summary>
    /// Literal for code: MedicationrequestStatusCompleted
    /// </summary>
    public const string LiteralMedicationrequestStatusCompleted = "http://hl7.org/fhir/CodeSystem/medicationrequest-status#completed";

    /// <summary>
    /// Literal for code: Draft
    /// </summary>
    public const string LiteralDraft = "draft";

    /// <summary>
    /// Literal for code: MedicationrequestStatusDraft
    /// </summary>
    public const string LiteralMedicationrequestStatusDraft = "http://hl7.org/fhir/CodeSystem/medicationrequest-status#draft";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: MedicationrequestStatusEnteredInError
    /// </summary>
    public const string LiteralMedicationrequestStatusEnteredInError = "http://hl7.org/fhir/CodeSystem/medicationrequest-status#entered-in-error";

    /// <summary>
    /// Literal for code: OnHold
    /// </summary>
    public const string LiteralOnHold = "on-hold";

    /// <summary>
    /// Literal for code: MedicationrequestStatusOnHold
    /// </summary>
    public const string LiteralMedicationrequestStatusOnHold = "http://hl7.org/fhir/CodeSystem/medicationrequest-status#on-hold";

    /// <summary>
    /// Literal for code: Stopped
    /// </summary>
    public const string LiteralStopped = "stopped";

    /// <summary>
    /// Literal for code: MedicationrequestStatusStopped
    /// </summary>
    public const string LiteralMedicationrequestStatusStopped = "http://hl7.org/fhir/CodeSystem/medicationrequest-status#stopped";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: MedicationrequestStatusUnknown
    /// </summary>
    public const string LiteralMedicationrequestStatusUnknown = "http://hl7.org/fhir/CodeSystem/medicationrequest-status#unknown";

    /// <summary>
    /// Dictionary for looking up MedicationrequestStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/CodeSystem/medicationrequest-status#active", Active }, 
      { "cancelled", Cancelled }, 
      { "http://hl7.org/fhir/CodeSystem/medicationrequest-status#cancelled", Cancelled }, 
      { "completed", Completed }, 
      { "http://hl7.org/fhir/CodeSystem/medicationrequest-status#completed", Completed }, 
      { "draft", Draft }, 
      { "http://hl7.org/fhir/CodeSystem/medicationrequest-status#draft", Draft }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/CodeSystem/medicationrequest-status#entered-in-error", EnteredInError }, 
      { "on-hold", OnHold }, 
      { "http://hl7.org/fhir/CodeSystem/medicationrequest-status#on-hold", OnHold }, 
      { "stopped", Stopped }, 
      { "http://hl7.org/fhir/CodeSystem/medicationrequest-status#stopped", Stopped }, 
      { "unknown", Unknown }, 
      { "http://hl7.org/fhir/CodeSystem/medicationrequest-status#unknown", Unknown }, 
    };
  };
}