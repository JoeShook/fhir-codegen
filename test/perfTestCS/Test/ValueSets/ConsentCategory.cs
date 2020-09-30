// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// This value set includes sample Consent Directive Type codes, including several consent directive related LOINC codes; HL7 VALUE SET: ActConsentType(2.16.840.1.113883.1.11.19897); examples of US realm consent directive legal descriptions and references to online and/or downloadable forms such as the SSA-827 Authorization to Disclose Information to the Social Security Administration; and other anticipated consent directives related to participation in a clinical trial, medical procedures, reproductive procedures; health care directive (Living Will); advance directive, do not resuscitate (DNR); Physician Orders for Life-Sustaining Treatment (POLST)
  /// </summary>
  public static class ConsentCategoryCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PrivacyPolicyAcknowledgementDocument_ = new Coding
    {
      Code = "57016-8",
      Display = "Privacy policy acknowledgement Document",
      System = "http://loinc.org"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PrivacyPolicyOrganizationDocument_ = new Coding
    {
      Code = "57017-6",
      Display = "Privacy policy Organization Document ",
      System = "http://loinc.org"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientConsent_ = new Coding
    {
      Code = "59284-0",
      Display = "Patient Consent ",
      System = "http://loinc.org"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ReleaseOfInformationConsent_ = new Coding
    {
      Code = "64292-6",
      Display = "Release of information consent ",
      System = "http://loinc.org"
    };
    /// <summary>
    /// Any instructions, written or given verbally by a patient to a health care provider in anticipation of potential need for medical treatment. [2005 Honor My Wishes]
    /// </summary>
    public static readonly Coding AdvanceDirective_consent_category = new Coding
    {
      Code = "acd",
      Display = "Advance Directive",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// A legal document, signed by both the patient and their provider, stating a desire not to have CPR initiated in case of a cardiac event. Note: This form was replaced in 2003 with the Physician Orders for Life-Sustaining Treatment [POLST].
    /// </summary>
    public static readonly Coding DoNotResuscitate_consent_category = new Coding
    {
      Code = "dnr",
      Display = "Do Not Resuscitate",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// Opt-in to disclosure of health information for emergency only consent directive. Comment: This general consent directive specifically limits disclosure of health information for purpose of emergency treatment. Additional parameters may further limit the disclosure to specific users, roles, duration, types of information, and impose uses obligations. [ActConsentDirective (2.16.840.1.113883.1.11.20425)]
    /// </summary>
    public static readonly Coding EmergencyOnly_consent_category = new Coding
    {
      Code = "emrgonly",
      Display = "Emergency Only",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// Patient's document telling patient's health care provider what the patient wants or does not want if the patient is diagnosed as being terminally ill and in a persistent vegetative state or in a permanently unconscious condition.[2005 Honor My Wishes]
    /// </summary>
    public static readonly Coding HealthCareDirective_consent_category = new Coding
    {
      Code = "hcd",
      Display = "Health Care Directive",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// Definition: Consent to have healthcare information collected in an electronic health record.  This entails that the information may be used in analysis, modified, updated.
    /// </summary>
    public static readonly Coding InformationCollection_v3_ActCode = new Coding
    {
      Code = "ICOL",
      Display = "information collection",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Definition: Consent to have collected healthcare information disclosed.
    /// </summary>
    public static readonly Coding InformationDisclosure_v3_ActCode = new Coding
    {
      Code = "IDSCL",
      Display = "information disclosure",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Definition: Consent to access healthcare information.
    /// </summary>
    public static readonly Coding InformationAccess_v3_ActCode = new Coding
    {
      Code = "INFA",
      Display = "information access",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Definition: Consent to access or "read" only, which entails that the information is not to be copied, screen printed, saved, emailed, stored, re-disclosed or altered in any way.  This level ensures that data which is masked or to which access is restricted will not be.
    /// 
    ///                         
    ///                            Example: Opened and then emailed or screen printed for use outside of the consent directive purpose.
    /// </summary>
    public static readonly Coding AccessOnly_v3_ActCode = new Coding
    {
      Code = "INFAO",
      Display = "access only",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Definition: Consent to access and save only, which entails that access to the saved copy will remain locked.
    /// </summary>
    public static readonly Coding AccessAndSaveOnly_v3_ActCode = new Coding
    {
      Code = "INFASO",
      Display = "access and save only",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Definition: Information re-disclosed without the patient's consent.
    /// </summary>
    public static readonly Coding InformationRedisclosure_v3_ActCode = new Coding
    {
      Code = "IRDSCL",
      Display = "information redisclosure",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Acknowledgement of custodian notice of privacy practices. Usage Notes: This type of consent directive acknowledges a custodian's notice of privacy practices including its permitted collection, access, use and disclosure of health information to users and for purposes of use specified. [ActConsentDirective (2.16.840.1.113883.1.11.20425)]
    /// </summary>
    public static readonly Coding NoticeOfPrivacyPractices_consent_category = new Coding
    {
      Code = "npp",
      Display = "Notice of Privacy Practices",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// The Physician Order for Life-Sustaining Treatment form records a person's health care wishes for end of life emergency treatment and translates them into an order by the physician. It must be reviewed and signed by both the patient and the physician, Advanced Registered Nurse Practitioner or Physician Assistant. [2005 Honor My Wishes] Comment: Opt-in Consent Directive with restrictions.
    /// </summary>
    public static readonly Coding POLST_consent_category = new Coding
    {
      Code = "polst",
      Display = "POLST",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// Consent to have healthcare information in an electronic health record accessed for research purposes. [VALUE SET: ActConsentType (2.16.840.1.113883.1.11.19897)]
    /// </summary>
    public static readonly Coding ResearchInformationAccess_consent_category = new Coding
    {
      Code = "research",
      Display = "Research Information Access",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// Definition: Consent to have healthcare information in an electronic health record accessed for research purposes.
    /// </summary>
    public static readonly Coding ResearchInformationAccess_v3_ActCode = new Coding
    {
      Code = "RESEARCH",
      Display = "research information access",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Consent to have de-identified healthcare information in an electronic health record that is accessed for research purposes, but without consent to re-identify the information under any circumstance. [VALUE SET: ActConsentType (2.16.840.1.113883.1.11.19897)
    /// </summary>
    public static readonly Coding DeIdentifiedInformationAccess_consent_category = new Coding
    {
      Code = "rsdid",
      Display = "De-identified Information Access",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// Definition: Consent to have de-identified healthcare information in an electronic health record that is accessed for research purposes, but without consent to re-identify the information under any circumstance.
    /// </summary>
    public static readonly Coding DeIdentifiedInformationAccess_v3_ActCode = new Coding
    {
      Code = "RSDID",
      Display = "de-identified information access",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Consent to have de-identified healthcare information in an electronic health record that is accessed for research purposes re-identified under specific circumstances outlined in the consent. [VALUE SET: ActConsentType (2.16.840.1.113883.1.11.19897)]
    /// </summary>
    public static readonly Coding ReIdentifiableInformationAccess_consent_category = new Coding
    {
      Code = "rsreid",
      Display = "Re-identifiable Information Access",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// Definition: Consent to have de-identified healthcare information in an electronic health record that is accessed for research purposes re-identified under specific circumstances outlined in the consent.
    /// 
    ///                         
    ///                            Example:: Where there is a need to inform the subject of potential health issues.
    /// </summary>
    public static readonly Coding ReIdentifiableInformationAccess_v3_ActCode = new Coding
    {
      Code = "RSREID",
      Display = "re-identifiable information access",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
  };
}
