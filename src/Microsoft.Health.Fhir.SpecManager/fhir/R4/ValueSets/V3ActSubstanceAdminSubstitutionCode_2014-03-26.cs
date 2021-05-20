// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// No Description Provided
  /// </summary>
  public static class V3ActSubstanceAdminSubstitutionCodeCodes
  {
    /// <summary>
    /// Description: 
    ///                         
    /// 
    ///                         Substitution occurred or is permitted between equivalent Brands but not Generics
    /// 
    ///                         
    ///                            Examples: 
    ///                         
    /// 
    ///                         
    ///                            Zestril  for Prinivil
    ///                            Coumadin for Jantoven
    /// </summary>
    public static readonly Coding BrandComposition = new Coding
    {
      Code = "BC",
      Display = "brand composition",
      System = "http://terminology.hl7.org/CodeSystem/v3-substanceAdminSubstitution"
    };
    /// <summary>
    /// Description: Substitution occurred or is permitted with another bioequivalent and therapeutically equivalent product.
    /// </summary>
    public static readonly Coding Equivalent = new Coding
    {
      Code = "E",
      Display = "equivalent",
      System = "http://terminology.hl7.org/CodeSystem/v3-substanceAdminSubstitution"
    };
    /// <summary>
    /// Description: 
    ///                         
    /// 
    ///                         Substitution occurred or is permitted with another product that is a:
    /// 
    ///                         
    ///                            pharmaceutical alternative containing the same active ingredient but is formulated with different salt, ester
    ///                            pharmaceutical equivalent that has the same active ingredient, strength, dosage form and route of administration
    ///                         
    ///                         
    ///                            Examples: 
    ///                         
    /// 
    ///                         
    ///                            
    ///                               Pharmaceutical alternative: Erythromycin Ethylsuccinate for Erythromycin Stearate
    ///                            
    ///                               Pharmaceutical equivalent: Lisonpril for Zestril
    /// </summary>
    public static readonly Coding EquivalentComposition = new Coding
    {
      Code = "EC",
      Display = "equivalent composition",
      System = "http://terminology.hl7.org/CodeSystem/v3-substanceAdminSubstitution"
    };
    /// <summary>
    /// Description: This substitution was performed or is permitted based on formulary guidelines.
    /// </summary>
    public static readonly Coding Formulary = new Coding
    {
      Code = "F",
      Display = "formulary",
      System = "http://terminology.hl7.org/CodeSystem/v3-substanceAdminSubstitution"
    };
    /// <summary>
    /// Description: Substitution occurred or is permitted between equivalent Generics but not Brands
    /// 
    ///                         
    ///                            Examples: 
    ///                         
    /// 
    ///                         
    ///                            Lisnopril (Lupin Corp) for Lisnopril (Wockhardt Corp)
    /// </summary>
    public static readonly Coding GenericComposition = new Coding
    {
      Code = "G",
      Display = "generic composition",
      System = "http://terminology.hl7.org/CodeSystem/v3-substanceAdminSubstitution"
    };
    /// <summary>
    /// No substitution occurred or is permitted.
    /// </summary>
    public static readonly Coding None = new Coding
    {
      Code = "N",
      Display = "none",
      System = "http://terminology.hl7.org/CodeSystem/v3-substanceAdminSubstitution"
    };
    /// <summary>
    /// Description: Substitution occurred or is permitted between therapeutically equivalent Brands but not Generics
    /// &gt;
    ///                            Examples: 
    ///                         
    /// 
    ///                         
    ///                            Zantac for Tagamet
    /// </summary>
    public static readonly Coding TherapeuticBrand = new Coding
    {
      Code = "TB",
      Display = "therapeutic brand",
      System = "http://terminology.hl7.org/CodeSystem/v3-substanceAdminSubstitution"
    };
    /// <summary>
    /// Description: Substitution occurred or is permitted with another product having the same therapeutic objective and safety profile.
    /// 
    ///                         
    ///                            Examples: 
    ///                         
    /// 
    ///                         
    ///                            ranitidine for Tagamet
    /// </summary>
    public static readonly Coding TherapeuticAlternative = new Coding
    {
      Code = "TE",
      Display = "therapeutic alternative",
      System = "http://terminology.hl7.org/CodeSystem/v3-substanceAdminSubstitution"
    };
    /// <summary>
    /// Description: Substitution occurred or is permitted between therapeutically equivalent Generics but not Brands
    /// &gt;
    ///                            Examples: 
    ///                         
    /// 
    ///                         
    ///                            Ranitidine  for cimetidine
    /// </summary>
    public static readonly Coding TherapeuticGeneric = new Coding
    {
      Code = "TG",
      Display = "therapeutic generic",
      System = "http://terminology.hl7.org/CodeSystem/v3-substanceAdminSubstitution"
    };
  };
}
