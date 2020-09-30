// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// This example value set defines a set of codes that can be used to indicate the type of encounter: a specific code indicating type of service provided.
  /// </summary>
  public static class EncounterTypeCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AnnualDiabetesMellitusScreening = new Coding
    {
      Code = "ADMS",
      Display = "Annual diabetes mellitus screening",
      System = "http://terminology.hl7.org/CodeSystem/encounter-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding BoneDrillingBoneMarrowPunctionInClinic = new Coding
    {
      Code = "BD/BM-clin",
      Display = "Bone drilling/bone marrow punction in clinic",
      System = "http://terminology.hl7.org/CodeSystem/encounter-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding InfantColonScreening60Minutes = new Coding
    {
      Code = "CCS60",
      Display = "Infant colon screening - 60 minutes",
      System = "http://terminology.hl7.org/CodeSystem/encounter-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OutpatientKenacortInjection = new Coding
    {
      Code = "OKI",
      Display = "Outpatient Kenacort injection",
      System = "http://terminology.hl7.org/CodeSystem/encounter-type"
    };
  };
}
