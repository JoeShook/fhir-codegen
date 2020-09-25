// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// This value set includes example Diagnosis Type codes.
  /// </summary>
  public static class ExDiagnosistypeCodes
  {
    /// <summary>
    /// The diagnosis given as the reason why the patient was admitted to the hospital.
    /// </summary>
    public static readonly Coding AdmittingDiagnosis = new Coding
    {
      Code = "admitting",
      Display = "Admitting Diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosistype"
    };
    /// <summary>
    /// A diagnosis made on the basis of medical signs and patient-reported symptoms, rather than diagnostic tests.
    /// </summary>
    public static readonly Coding ClinicalDiagnosis = new Coding
    {
      Code = "clinical",
      Display = "Clinical Diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosistype"
    };
    /// <summary>
    /// One of a set of the possible diagnoses that could be connected to the signs, symptoms, and lab findings.
    /// </summary>
    public static readonly Coding DifferentialDiagnosis = new Coding
    {
      Code = "differential",
      Display = "Differential Diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosistype"
    };
    /// <summary>
    /// The diagnosis given when the patient is discharged from the hospital.
    /// </summary>
    public static readonly Coding DischargeDiagnosis = new Coding
    {
      Code = "discharge",
      Display = "Discharge Diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosistype"
    };
    /// <summary>
    /// A diagnosis based significantly on laboratory reports or test results, rather than the physical examination of the patient.
    /// </summary>
    public static readonly Coding LaboratoryDiagnosis = new Coding
    {
      Code = "laboratory",
      Display = "Laboratory Diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosistype"
    };
    /// <summary>
    /// A diagnosis which identifies people's responses to situations in their lives, such as a readiness to change or a willingness to accept assistance.
    /// </summary>
    public static readonly Coding NursingDiagnosis = new Coding
    {
      Code = "nursing",
      Display = "Nursing Diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosistype"
    };
    /// <summary>
    /// A diagnosis determined prior to birth.
    /// </summary>
    public static readonly Coding PrenatalDiagnosis = new Coding
    {
      Code = "prenatal",
      Display = "Prenatal Diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosistype"
    };
    /// <summary>
    /// The single medical diagnosis that is most relevant to the patient's chief complaint or need for treatment.
    /// </summary>
    public static readonly Coding PrincipalDiagnosis = new Coding
    {
      Code = "principal",
      Display = "Principal Diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosistype"
    };
    /// <summary>
    /// A diagnosis based primarily on the results from medical imaging studies.
    /// </summary>
    public static readonly Coding RadiologyDiagnosis = new Coding
    {
      Code = "radiology",
      Display = "Radiology Diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosistype"
    };
    /// <summary>
    /// A diagnosis determined using telemedicine techniques.
    /// </summary>
    public static readonly Coding RemoteDiagnosis = new Coding
    {
      Code = "remote",
      Display = "Remote Diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosistype"
    };
    /// <summary>
    /// The labeling of an illness in a specific historical event using modern knowledge, methods and disease classifications.
    /// </summary>
    public static readonly Coding RetrospectiveDiagnosis = new Coding
    {
      Code = "retrospective",
      Display = "Retrospective Diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosistype"
    };
    /// <summary>
    /// A diagnosis determined by the patient.
    /// </summary>
    public static readonly Coding SelfDiagnosis = new Coding
    {
      Code = "self",
      Display = "Self Diagnosis",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosistype"
    };
  };
}
