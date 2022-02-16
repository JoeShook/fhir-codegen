// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes sample Coverage Copayment Type codes.
  /// </summary>
  public static class CoverageCopayTypeCodes
  {
    /// <summary>
    /// A standard fixed currency amount applied to all classes or service or product not otherwise specified.
    /// </summary>
    public static readonly Coding CopayAmount = new Coding
    {
      Code = "copay",
      Display = "Copay Amount",
      System = "http://terminology.hl7.org/CodeSystem/coverage-copay-type"
    };
    /// <summary>
    /// A standard percentage applied to all classes or service or product not otherwise specified.
    /// </summary>
    public static readonly Coding CopayPercentage = new Coding
    {
      Code = "copaypct",
      Display = "Copay Percentage",
      System = "http://terminology.hl7.org/CodeSystem/coverage-copay-type"
    };
    /// <summary>
    /// The accumulated amount of patient payment before the coverage begins to pay for services.
    /// </summary>
    public static readonly Coding Deductible = new Coding
    {
      Code = "deductible",
      Display = "Deductible",
      System = "http://terminology.hl7.org/CodeSystem/coverage-copay-type"
    };
    /// <summary>
    /// An episode in an emergency department.
    /// </summary>
    public static readonly Coding Emergency = new Coding
    {
      Code = "emergency",
      Display = "Emergency",
      System = "http://terminology.hl7.org/CodeSystem/coverage-copay-type"
    };
    /// <summary>
    /// An office visit for a general practitioner of a discipline.
    /// </summary>
    public static readonly Coding GPOfficeVisit = new Coding
    {
      Code = "gpvisit",
      Display = "GP Office Visit",
      System = "http://terminology.hl7.org/CodeSystem/coverage-copay-type"
    };
    /// <summary>
    /// An episode of an Inpatient hospital stay.
    /// </summary>
    public static readonly Coding InpatientHospital = new Coding
    {
      Code = "inpthosp",
      Display = "Inpatient Hospital",
      System = "http://terminology.hl7.org/CodeSystem/coverage-copay-type"
    };
    /// <summary>
    /// The maximum amout of payment for services which a patient, or family, is expected to incur - typically annually.
    /// </summary>
    public static readonly Coding MaximumOutOfPocket = new Coding
    {
      Code = "maxoutofpocket",
      Display = "Maximum out of pocket",
      System = "http://terminology.hl7.org/CodeSystem/coverage-copay-type"
    };
    /// <summary>
    /// An office visit for a specialist practitioner of a discipline
    /// </summary>
    public static readonly Coding SpecialistOfficeVisit = new Coding
    {
      Code = "spvisit",
      Display = "Specialist Office Visit",
      System = "http://terminology.hl7.org/CodeSystem/coverage-copay-type"
    };
    /// <summary>
    /// A visit held where the patient is remote relative to the practitioner, e.g. by phone, computer or video conference.
    /// </summary>
    public static readonly Coding TeleVisit = new Coding
    {
      Code = "televisit",
      Display = "Tele-visit",
      System = "http://terminology.hl7.org/CodeSystem/coverage-copay-type"
    };
    /// <summary>
    /// A visit to an urgent care facility - typically a community care clinic.
    /// </summary>
    public static readonly Coding UrgentCare = new Coding
    {
      Code = "urgentcare",
      Display = "Urgent Care",
      System = "http://terminology.hl7.org/CodeSystem/coverage-copay-type"
    };
  };
}