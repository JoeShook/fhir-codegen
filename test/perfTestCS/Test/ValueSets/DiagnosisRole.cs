// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// This value set defines a set of codes that can be used to express the role of a diagnosis on the Encounter or EpisodeOfCare record.
  /// </summary>
  public static class DiagnosisRoleCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AdmissionDiagnosis = new Coding
    {
      Code = "AD",
      Display = "Admission diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/diagnosis-role"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Billing = new Coding
    {
      Code = "billing",
      Display = "Billing",
      System = "http://terminology.hl7.org/CodeSystem/diagnosis-role"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ChiefComplaint = new Coding
    {
      Code = "CC",
      Display = "Chief complaint",
      System = "http://terminology.hl7.org/CodeSystem/diagnosis-role"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ComorbidityDiagnosis = new Coding
    {
      Code = "CM",
      Display = "Comorbidity diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/diagnosis-role"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding DischargeDiagnosis = new Coding
    {
      Code = "DD",
      Display = "Discharge diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/diagnosis-role"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PostOpDiagnosis = new Coding
    {
      Code = "post-op",
      Display = "post-op diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/diagnosis-role"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PreOpDiagnosis = new Coding
    {
      Code = "pre-op",
      Display = "pre-op diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/diagnosis-role"
    };
  };
}
