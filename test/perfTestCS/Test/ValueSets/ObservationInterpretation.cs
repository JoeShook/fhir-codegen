// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// A categorical assessment, providing a rough qualitative interpretation of the observation value,    such as “normal”/ “abnormal”,”low” / “high”, “better” / “worse”, “susceptible” / “resistant”, “expected”/ “not expected”.    The value set is intended to be for ANY use where coded representation of an interpretation is needed.   
  ///    
  ///    Notes:
  ///    
  ///    This is being communicated in v2.x in OBX-8 (Observation Interpretation), in v3 in ObservationInterpretation (CWE) in R1 (Representative Realm) and in FHIR in    Observation.interpretation. Historically these values come from the laboratory domain, and these codes are extensively    used. The value set binding is extensible, so codes outside the value set that are needed for interpretation concepts    (i.e. particular meanings) that are not included in the value set can be used, and these new codes may also be added to    the value set and published in a future version.
  /// </summary>
  public static class ObservationInterpretationCodes
  {
    /// <summary>
    /// Codes that specify interpretation of genetic analysis, such as "positive", "negative", "carrier", "responsive", etc.
    /// </summary>
    public static readonly Coding GeneticObservationInterpretation = new Coding
    {
      Code = "_GeneticObservationInterpretation",
      Display = "GeneticObservationInterpretation",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// Interpretations of change of quantity and/or severity. At most one of B or W and one of U or D allowed.
    /// </summary>
    public static readonly Coding ObservationInterpretationChange = new Coding
    {
      Code = "_ObservationInterpretationChange",
      Display = "ObservationInterpretationChange",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// Technical exceptions resulting in the inability to provide an interpretation. At most one allowed. Does not imply normality or severity.
    /// </summary>
    public static readonly Coding ObservationInterpretationExceptions = new Coding
    {
      Code = "_ObservationInterpretationExceptions",
      Display = "ObservationInterpretationExceptions",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// Interpretation of normality or degree of abnormality (including critical or "alert" level). Concepts in this category are mutually exclusive, i.e., at most one is allowed.
    /// </summary>
    public static readonly Coding ObservationInterpretationNormality = new Coding
    {
      Code = "_ObservationInterpretationNormality",
      Display = "ObservationInterpretationNormality",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// Interpretations of anti-microbial susceptibility testing results (microbiology). At most one allowed.
    /// </summary>
    public static readonly Coding ObservationInterpretationSusceptibility = new Coding
    {
      Code = "_ObservationInterpretationSusceptibility",
      Display = "ObservationInterpretationSusceptibility",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The result is below the minimum detection limit (the test procedure or equipment is the limiting factor).
    /// 
    ///                         Synonyms: Below analytical limit, low off scale.
    /// </summary>
    public static readonly Coding OffScaleLow = new Coding
    {
      Code = "<",
      Display = "Off scale low",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The result is above the maximum quantifiable limit (the test procedure or equipment is the limiting factor).
    /// 
    ///                         Synonyms: Above analytical limit, high off scale.
    /// </summary>
    public static readonly Coding OffScaleHigh = new Coding
    {
      Code = ">",
      Display = "Off scale high",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The result or observation value is outside the reference range or expected norm (as defined for the respective test procedure).
    /// 
    ///                         [Note: Typically applies to non-numeric results.]
    /// </summary>
    public static readonly Coding Abnormal = new Coding
    {
      Code = "A",
      Display = "Abnormal",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The result or observation value is outside a reference range or expected norm at a level at which immediate action should be considered for patient safety (as defined for the respective test procedure).
    /// 
    ///                         [Note: Typically applies to non-numeric results.  Analogous to critical/panic limits for numeric results.]
    /// </summary>
    public static readonly Coding CriticalAbnormal = new Coding
    {
      Code = "AA",
      Display = "Critical abnormal",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The current result or observation value has improved compared to the previous result or observation value (the change is significant as defined in the respective test procedure).
    /// 
    ///                         [Note: This can be applied to quantitative or qualitative observations.]
    /// </summary>
    public static readonly Coding Better = new Coding
    {
      Code = "B",
      Display = "Better",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The patient is considered as carrier based on the testing results. A carrier is an individual who carries an altered form of a gene which can lead to having a child or offspring in future generations with a genetic disorder.
    /// </summary>
    public static readonly Coding Carrier = new Coding
    {
      Code = "CAR",
      Display = "Carrier",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The current result has decreased from the previous result for a quantitative observation (the change is significant as defined in the respective test procedure).
    /// </summary>
    public static readonly Coding SignificantChangeDown = new Coding
    {
      Code = "D",
      Display = "Significant change down",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The measurement of the specified component / analyte, organism or clinical sign above the limit of detection of the performed test or procedure.
    /// </summary>
    public static readonly Coding Detected = new Coding
    {
      Code = "DET",
      Display = "Detected",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The test or procedure was successfully performed, but the results are borderline and can neither be declared positive / negative nor detected / not detected according to the current established criteria.
    /// </summary>
    public static readonly Coding Equivocal = new Coding
    {
      Code = "E",
      Display = "Equivocal",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The observation/test result is interpreted as being outside the inclusion range for a particular protocol within which the result is being reported.
    /// 
    ///                         Example: A positive result on a Hepatitis screening test.
    ///                            Open Issue: EX, HX, LX: These three concepts do not seem to meet a clear need in the vocabulary, and their use in observation interpretation appears likely to be covered by other existing concepts (e.g., A, H, L).  The only apparent significant difference is their reference to use in protocols for exclusion of study subjects.
    /// These concepts/codes were proposed by RCRIM for use in the CTLaboratory message.  They were submitted and approved in the November 2005 Harmonization cycle in proposal "030103C_VOCAB_RCRIM_l_quade_RCRIM Obs Interp_20051028154455".  However, this proposal was not fully implemented in the vocabulary.  The proposal recommended creation of the x_ClinicalResearchExclusion domain in ObservationInterpretation with a value set including those three concepts/codes, but there is no subdomain of that name or equivalent with a binding to either of the value sets that contain these concepts/codes.
    /// Members of the OO WG have recently attempted to contact members of RCRIM regarding these concepts, both by email and at the recent WGM in Atlanta, without response.  It is felt by OO that the best course of action to take at this time is to add this comprehensive Open Issue rather than deprecate these three concepts at this time, until further discussion is held.
    /// </summary>
    public static readonly Coding OutsideThreshold = new Coding
    {
      Code = "EX",
      Display = "outside threshold",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// This result has been evaluated in light of known contraindicators.  Once those contraindicators have been taken into account the result is determined to be "Expected"  (e.g., presence of drugs in a patient that is taking prescription medication for pain management).
    /// </summary>
    public static readonly Coding Expected = new Coding
    {
      Code = "EXP",
      Display = "Expected",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The result for a quantitative observation is above the upper limit of the reference range (as defined for the respective test procedure).
    /// 
    ///                         Synonym: Above high normal
    /// </summary>
    public static readonly Coding High = new Coding
    {
      Code = "H",
      Display = "High",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The result for a quantitative observation is above a reference level at which immediate action should be considered for patient safety (as defined for the respective test procedure).
    /// 
    ///                         Synonym: Above upper panic limits.
    /// </summary>
    public static readonly Coding CriticalHigh = new Coding
    {
      Code = "HH",
      Display = "Critical high",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// A test result that is significantly higher than the reference (normal) or therapeutic interval, but has not reached the critically high value and might need special attention, as defined by the laboratory or the clinician.
    /// </summary>
    public static readonly Coding SignificantlyHigh = new Coding
    {
      Code = "HU",
      Display = "Significantly high",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The observation/test result is interpreted as being outside the inclusion range for a particular protocol within which the result is being reported.
    /// 
    ///                         Example: A positive result on a Hepatitis screening test.
    ///                            Open Issue: EX, HX, LX: These three concepts do not seem to meet a clear need in the vocabulary, and their use in observation interpretation appears likely to be covered by other existing concepts (e.g., A, H, L).  The only apparent significant difference is their reference to use in protocols for exclusion of study subjects.  These concepts/codes were proposed by RCRIM for use in the CTLaboratory message.  They were submitted and approved in the November 2005 Harmonization cycle in proposal "030103C_VOCAB_RCRIM_l_quade_RCRIM Obs Interp_20051028154455". However, this proposal was not fully implemented in the vocabulary.  The proposal recommended creation of the x_ClinicalResearchExclusion domain in ObservationInterpretation with a value set including those three concepts/codes, but there is no subdomain of that name or equivalent with a binding to either of the value sets that contain these concepts/codes.  Members of the OO WG have recently attempted to contact members of RCRIM regarding these concepts, both by email and at the recent WGM in Atlanta, without response.  It is felt by OO that the best course of action to take at this time is to add this comprehensive Open Issue rather than deprecate these three concepts at this time, until further discussion is held.
    /// </summary>
    public static readonly Coding AboveHighThreshold = new Coding
    {
      Code = "HX",
      Display = "above high threshold",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// Bacterial strain inhibited in vitro by a concentration of an antimicrobial agent that is associated with uncertain therapeutic effect. Reference: CLSI (http://www.clsi.org/Content/NavigationMenu/Resources/HarmonizedTerminologyDatabase/Harmonized_Terminolo.htm)
    /// Projects: ISO 20776-1, ISO 20776-2
    /// 
    ///                         [Note 1: Bacterial strains are categorized as intermediate by applying the appropriate breakpoints in a defined phenotypic test system.]
    /// 
    ///                         [Note 2: This class of susceptibility implies that an infection due to the isolate can be appropriately treated in body sites where the drugs are physiologically concentrated or when a high dosage of drug can be used.]
    /// 
    ///                         [Note 3: This class also indicates a "buffer zone," to prevent small, uncontrolled, technical factors from causing major discrepancies in interpretations.]
    /// 
    ///                         [Note 4: These breakpoints can be altered due to changes in circumstances (e.g., changes in commonly used drug dosages, emergence of new resistance mechanisms).]
    /// </summary>
    public static readonly Coding Intermediate = new Coding
    {
      Code = "I",
      Display = "Intermediate",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// There is insufficient evidence that the species in question is a good target for therapy with the drug.  A categorical interpretation is not possible.
    /// 
    ///                         [Note: A MIC with "IE" and/or a comment may be reported (without an accompanying S, I or R-categorization).]
    /// </summary>
    public static readonly Coding InsufficientEvidence = new Coding
    {
      Code = "IE",
      Display = "Insufficient evidence",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The specified component / analyte, organism or clinical sign could neither be declared positive / negative nor detected / not detected by the performed test or procedure.
    /// 
    ///                         
    ///                            Usage Note: For example, if the specimen was degraded, poorly processed, or was missing the required anatomic structures, then "indeterminate" (i.e. "cannot be determined") is the appropriate response, not "equivocal".
    /// </summary>
    public static readonly Coding Indeterminate = new Coding
    {
      Code = "IND",
      Display = "Indeterminate",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The result for a quantitative observation is below the lower limit of the reference range (as defined for the respective test procedure).
    /// 
    ///                         Synonym: Below low normal
    /// </summary>
    public static readonly Coding Low = new Coding
    {
      Code = "L",
      Display = "Low",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The result for a quantitative observation is below a reference level at which immediate action should be considered for patient safety (as defined for the respective test procedure).
    /// 
    ///                         Synonym: Below lower panic limits.
    /// </summary>
    public static readonly Coding CriticalLow = new Coding
    {
      Code = "LL",
      Display = "Critical low",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// A test result that is significantly lower than the reference (normal) or therapeutic interval, but has not reached the critically low value and might need special attention, as defined by the laboratory or the clinician.
    /// </summary>
    public static readonly Coding SignificantlyLow = new Coding
    {
      Code = "LU",
      Display = "Significantly low",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The numeric observation/test result is interpreted as being below the low threshold value for a particular protocol within which the result is being reported.
    /// 
    ///                         Example: A Total White Blood Cell Count falling below a protocol-defined threshold value of 3000/mm^3
    ///                            Open Issue: EX, HX, LX: These three concepts do not seem to meet a clear need in the vocabulary, and their use in observation interpretation appears likely to be covered by other existing concepts (e.g., A, H, L).  The only apparent significant difference is their reference to use in protocols for exclusion of study subjects.  These concepts/codes were proposed by RCRIM for use in the CTLaboratory message.  They were submitted and approved in the November 2005 Harmonization cycle in proposal "030103C_VOCAB_RCRIM_l_quade_RCRIM Obs Interp_20051028154455".  However, this proposal was not fully implemented in the vocabulary.  The proposal recommended creation of the x_ClinicalResearchExclusion domain in ObservationInterpretation with a value set including those three concepts/codes, but there is no subdomain of that name or equivalent with a binding to either of the value sets that contain these concepts/codes.  Members of the OO WG have recently attempted to contact members of RCRIM regarding these concepts, both by email and at the recent WGM in Atlanta, without response.  It is felt by OO that the best course of action to take at this time is to add this comprehensive Open Issue rather than deprecate these three concepts at this time, until further discussion is held.
    /// </summary>
    public static readonly Coding BelowLowThreshold = new Coding
    {
      Code = "LX",
      Display = "below low threshold",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The result or observation value is within the reference range or expected norm (as defined for the respective test procedure).
    /// 
    ///                         [Note: Applies to numeric or non-numeric results.]
    /// </summary>
    public static readonly Coding Normal = new Coding
    {
      Code = "N",
      Display = "Normal",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// Use when not enough clinical trial data published by the Clinical and Laboratory Standards Institutes (CLSI) is available to establish the breakpoints for susceptible / intermediate and resistant.
    /// </summary>
    public static readonly Coding NoCLSIDefinedBreakpoint = new Coding
    {
      Code = "NCL",
      Display = "No CLSI defined breakpoint",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The presence of the specified component / analyte, organism or clinical sign could not be determined within the limit of detection of the performed test or procedure.
    /// </summary>
    public static readonly Coding NotDetected = new Coding
    {
      Code = "ND",
      Display = "Not detected",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// An absence finding of the specified component / analyte, organism or clinical sign based on the established threshold of the performed test or procedure.
    /// 
    ///                         [Note: Negative does not necessarily imply the complete absence of the specified item.]
    /// </summary>
    public static readonly Coding Negative = new Coding
    {
      Code = "NEG",
      Display = "Negative",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// An absence finding used to indicate that the specified component / analyte did not react measurably with the reagent.
    /// </summary>
    public static readonly Coding NonReactive = new Coding
    {
      Code = "NR",
      Display = "Non-reactive",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// A category used for isolates for which only a susceptible interpretive criterion has been designated because of the absence or rare occurrence of resistant strains. Isolates that have MICs above or zone diameters below the value indicated for the susceptible breakpoint should be reported as non-susceptible.
    /// 
    ///                         NOTE 1: An isolate that is interpreted as non-susceptible does not necessarily mean that the isolate has a resistance mechanism. It is possible that isolates with MICs above the susceptible breakpoint that lack resistance mechanisms may be encountered within the wild-type distribution subsequent to the time the susceptible-only breakpoint is set. 
    /// 
    ///                         NOTE 2: For strains yielding results in the "nonsusceptible" category, organism identification and antimicrobial susceptibility test results should be confirmed.
    /// 
    ///                         Synonym: decreased susceptibility.
    /// </summary>
    public static readonly Coding NonSusceptible = new Coding
    {
      Code = "NS",
      Display = "Non-susceptible",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// Interpretations of the presence or absence of a component / analyte or organism in a test or of a sign in a clinical observation. In keeping with laboratory data processing practice, these concepts provide a categorical interpretation of the "meaning" of the quantitative value for the same observation.
    /// </summary>
    public static readonly Coding ObservationInterpretationDetection = new Coding
    {
      Code = "ObservationInterpretationDetection",
      Display = "ObservationInterpretationDetection",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// Interpretation of the observed result taking into account additional information (contraindicators) about the patient's situation. Concepts in this category are mutually exclusive, i.e., at most one is allowed.
    /// </summary>
    public static readonly Coding ObservationInterpretationExpectation = new Coding
    {
      Code = "ObservationInterpretationExpectation",
      Display = "ObservationInterpretationExpectation",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// A presence finding of the specified component / analyte, organism or clinical sign based on the established threshold of the performed test or procedure.
    /// </summary>
    public static readonly Coding Positive = new Coding
    {
      Code = "POS",
      Display = "Positive",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// Bacterial strain inhibited in vitro by a concentration of an antimicrobial agent that is associated with a high likelihood of therapeutic failure.
    /// Reference: CLSI (http://www.clsi.org/Content/NavigationMenu/Resources/HarmonizedTerminologyDatabase/Harmonized_Terminolo.htm)  
    /// Projects: ISO 20776-1, ISO 20776-2
    /// 
    ///                         [Note 1: Bacterial strains are categorized as resistant by applying the appropriate breakpoints in a defined phenotypic test system.]
    /// 
    ///                         [Note 2: This breakpoint can be altered due to changes in circumstances (e.g., changes in commonly used drug dosages, emergence of new resistance mechanisms).]
    /// </summary>
    public static readonly Coding Resistant = new Coding
    {
      Code = "R",
      Display = "Resistant",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// Interpretations of the presence and level of reactivity of the specified component / analyte with the reagent in the performed laboratory test.
    /// </summary>
    public static readonly Coding ReactivityObservationInterpretation = new Coding
    {
      Code = "ReactivityObservationInterpretation",
      Display = "ReactivityObservationInterpretation",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// A presence finding used to indicate that the specified component / analyte reacted with the reagent above the reliably measurable limit of the performed test.
    /// </summary>
    public static readonly Coding Reactive = new Coding
    {
      Code = "RR",
      Display = "Reactive",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// Bacterial strain inhibited by in vitro concentration of an antimicrobial agent that is associated with a high likelihood of therapeutic success.
    /// Reference: CLSI (http://www.clsi.org/Content/NavigationMenu/Resources/HarmonizedTerminologyDatabase/Harmonized_Terminolo.htm)
    /// Synonym (earlier term): Sensitive Projects: ISO 20776-1, ISO 20776-2
    /// 
    ///                         [Note 1: Bacterial strains are categorized as susceptible by applying the appropriate breakpoints in a defined phenotypic system.]
    /// 
    ///                         [Note 2: This breakpoint can be altered due to changes in circumstances (e.g., changes in commonly used drug dosages, emergence of new resistance mechanisms).]
    /// </summary>
    public static readonly Coding Susceptible = new Coding
    {
      Code = "S",
      Display = "Susceptible",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// A category that includes isolates with antimicrobial agent minimum inhibitory concentrations (MICs) that approach usually attainable blood and tissue levels and for which response rates may be lower than for susceptible isolates.
    /// 
    ///                         Reference: CLSI document M44-A2 2009 "Method for antifungal disk diffusion susceptibility testing of yeasts; approved guideline - second edition" - page 2.
    /// </summary>
    public static readonly Coding SusceptibleDoseDependent = new Coding
    {
      Code = "SDD",
      Display = "Susceptible-dose dependent",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// A category for isolates where the bacteria (e.g. enterococci) are not susceptible in vitro to a combination therapy (e.g., high-level aminoglycoside and cell wall active agent).  This is predictive that this combination therapy will not be effective. 
    /// 
    ///                         
    ///                            Usage Note: Since the use of penicillin or ampicillin alone often results in treatment failure of serious enterococcal or other bacterial infections, combination therapy is usually indicated to enhance bactericidal activity. The synergy between a cell wall active agent (such as penicillin, ampicillin, or vancomycin) and an aminoglycoside (such as gentamicin, kanamycin or streptomycin) is best predicted by screening for high-level bacterial resistance to the aminoglycoside.
    /// 
    ///                         
    ///                            Open Issue: The print name of the code is very general and the description is very specific to a pair of classes of agents, which may lead to confusion of these concepts in the future should other synergies be found.
    /// </summary>
    public static readonly Coding SynergyResistant = new Coding
    {
      Code = "SYN-R",
      Display = "Synergy - resistant",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// A category for isolates where the bacteria (e.g. enterococci) are susceptible in vitro to a combination therapy (e.g., high-level aminoglycoside and cell wall active agent).  This is predictive that this combination therapy will be effective. 
    /// 
    ///                         
    ///                            Usage Note: Since the use of penicillin or ampicillin alone often results in treatment failure of serious enterococcal or other bacterial infections, combination therapy is usually indicated to enhance bactericidal activity. The synergy between a cell wall active agent (such as penicillin, ampicillin, or vancomycin) and an aminoglycoside (such as gentamicin, kanamycin or streptomycin) is best predicted by screening for high-level bacterial resistance to the aminoglycoside.
    /// 
    ///                         
    ///                            Open Issue: The print name of the code is very general and the description is very specific to a pair of classes of agents, which may lead to confusion of these concepts in the future should other synergies be found.
    /// </summary>
    public static readonly Coding SynergySusceptible = new Coding
    {
      Code = "SYN-S",
      Display = "Synergy - susceptible",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The current result has increased from the previous result for a quantitative observation (the change is significant as defined in the respective test procedure).
    /// </summary>
    public static readonly Coding SignificantChangeUp = new Coding
    {
      Code = "U",
      Display = "Significant change up",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// This result has been evaluated in light of known contraindicators.  Once those contraindicators have been taken into account the result is determined to be "Unexpected" (e.g., presence of non-prescribed drugs in a patient that is taking prescription medication for pain management).
    /// </summary>
    public static readonly Coding Unexpected = new Coding
    {
      Code = "UNE",
      Display = "Unexpected",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// The current result or observation value has degraded compared to the previous result or observation value (the change is significant as defined in the respective test procedure).
    /// 
    ///                         [Note: This can be applied to quantitative or qualitative observations.]
    /// </summary>
    public static readonly Coding Worse = new Coding
    {
      Code = "W",
      Display = "Worse",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// A weighted presence finding used to indicate that the specified component / analyte reacted with the reagent, but below the reliably measurable limit of the performed test.
    /// </summary>
    public static readonly Coding WeaklyReactive = new Coding
    {
      Code = "WR",
      Display = "Weakly reactive",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
  };
}
