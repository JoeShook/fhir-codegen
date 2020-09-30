// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// This value set contains representative Activity Type codes, which includes codes from the HL7 DocumentCompletion, ActStatus, and DataOperations code system, W3C PROV-DM and PROV-N concepts and display names, several HL7 Lifecycle Event codes for which there are agreed upon definitions, and non-duplicated codes from the HL7 Security and Privacy Ontology Operations codes.
  /// </summary>
  public static class ProvenanceActivityTypeCodes
  {
    /// <summary>
    /// Participations related, but not primary to an act. The Referring, Admitting, and Discharging practitioners must be the same person as those authoring the ControlAct event for their respective trigger events.
    /// </summary>
    public static readonly Coding ParticipationAncillary_v3_ParticipationType = new Coding
    {
      Code = "_ParticipationAncillary",
      Display = "ParticipationAncillary",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Parties that may or should contribute or have contributed information to the Act. Such information includes information leading to the decision to perform the Act and how to perform the Act (e.g., consultant), information that the Act itself seeks to reveal (e.g., informant of clinical history), or information about what Act was performed (e.g., informant witness).
    /// </summary>
    public static readonly Coding ParticipationInformationGenerator_v3_ParticipationType = new Coding
    {
      Code = "_ParticipationInformationGenerator",
      Display = "ParticipationInformationGenerator",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// The practitioner who is responsible for admitting a patient to a patient encounter.
    /// </summary>
    public static readonly Coding Admitter_v3_ParticipationType = new Coding
    {
      Code = "ADM",
      Display = "admitter",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// The target of an Observation action. Links an observation to a Role whose player is the substance or most specific component entity (material, micro-organism, etc.) being measured within the subject.
    /// 
    ///                         
    ///                            Examples: A "plasma porcelain substance concentration" has analyte a Role with player substance Entity "porcelain".
    /// 
    ///                         
    ///                            UsageNotes: The Role that this participation connects to may be any Role whose player is that substance measured. Very often, the scoper may indicate the system in which the component is being measured. E.g., for "plasma porcelain" the scoper could be "Plasma".
    /// </summary>
    public static readonly Coding Analyte_v3_ParticipationType = new Coding
    {
      Code = "ALY",
      Display = "analyte",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Custodian system must remove any information that could result in identifying the information subject.
    /// </summary>
    public static readonly Coding Anonymize_v3_ActCode = new Coding
    {
      Code = "ANONY",
      Display = "anonymize",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Description:Fundamental operation in an Information System (IS) that results only in the addition of information to an object already in existence. Note: The preceding definition is taken from the HL7 RBAC specification.  There is no restriction on how the operation is invoked, e.g., via a user interface.
    /// </summary>
    public static readonly Coding Append_v3_DataOperation = new Coding
    {
      Code = "APPEND",
      Display = "append",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// The practitioner that has responsibility for overseeing a patient's care during a patient encounter.
    /// </summary>
    public static readonly Coding Attender_v3_ParticipationType = new Coding
    {
      Code = "ATND",
      Display = "attender",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Definition: A party that originates the Act and therefore has responsibility for the information given in the Act and ownership of this Act.
    /// 
    ///                         
    ///                            Example: the report writer, the person writing the act definition, the guideline author, the placer of an order, the EKG cart (device) creating a report etc. Every Act should have an author. Authorship is regardless of mood always actual authorship. 
    /// 
    ///                         Examples of such policies might include:
    /// 
    ///                         
    ///                            
    ///                               The author and anyone they explicitly delegate may update the report;
    /// 
    ///                            
    ///                            
    ///                               All administrators within the same clinic may cancel and reschedule appointments created by other administrators within that clinic;
    /// 
    ///                            
    ///                         
    ///                         A party that is neither an author nor a party who is extended authorship maintenance rights by policy, may only amend, reverse, override, replace, or follow up in other ways on this Act, whereby the Act remains intact and is linked to another Act authored by that other party.
    /// </summary>
    public static readonly Coding AuthorOriginator_v3_ParticipationType = new Coding
    {
      Code = "AUT",
      Display = "author (originator)",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A verifier who attests to the accuracy of an act, but who does not have privileges to legally authenticate the act. An example would be a resident physician who sees a patient and dictates a note, then later signs it. Their signature constitutes an authentication.
    /// </summary>
    public static readonly Coding Authenticator_v3_ParticipationType = new Coding
    {
      Code = "AUTHEN",
      Display = "authenticator",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// In an obstetric service, the baby.
    /// </summary>
    public static readonly Coding Baby_v3_ParticipationType = new Coding
    {
      Code = "BBY",
      Display = "baby",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Target on behalf of whom the service happens, but that is not necessarily present in the service.  Can occur together with direct target to indicate that a target is both, as in the case where the patient is the indirect beneficiary of a service rendered to a family member, e.g. counseling or given home care instructions.  This concept includes a participant, such as a covered party, who derives benefits from a service act covered by a coverage act.
    /// 
    ///                         Note that the semantic role of the intended recipient who benefits from the happening denoted by the verb in the clause.  Thus, a patient who has no coverage under a policy or program may be a beneficiary of a health service while not being the beneficiary of coverage for that service.
    /// </summary>
    public static readonly Coding Beneficiary_v3_ParticipationType = new Coding
    {
      Code = "BEN",
      Display = "beneficiary",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Definition: A factor, such as a microorganism, chemical substance, or form of radiation, whose presence, excessive presence, or (in deficiency diseases) relative absence is essential, in whole or in part, for the occurrence of a condition.
    /// 
    ///                         Constraint:  The use of this participation is limited to observations.
    /// </summary>
    public static readonly Coding CausativeAgent_v3_ParticipationType = new Coding
    {
      Code = "CAGNT",
      Display = "causative agent",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A person or organization who should be contacted for follow-up questions about the act in place of the author.
    /// </summary>
    public static readonly Coding CallbackContact_v3_ParticipationType = new Coding
    {
      Code = "CALLBCK",
      Display = "callback contact",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// The catalyst of a chemical reaction, such as an enzyme or a platinum surface. In biochemical reactions, connects the enzyme with the molecular interaction
    /// </summary>
    public static readonly Coding Catalyst_v3_ParticipationType = new Coding
    {
      Code = "CAT",
      Display = "catalyst",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// An advisor participating in the service by performing evaluations and making recommendations.
    /// </summary>
    public static readonly Coding Consultant_v3_ParticipationType = new Coding
    {
      Code = "CON",
      Display = "consultant",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// The target participation for an individual in a health care coverage act in which the target role is either the policy holder of the coverage, or a covered party under the coverage.
    /// </summary>
    public static readonly Coding CoverageTarget_v3_ParticipationType = new Coding
    {
      Code = "COV",
      Display = "coverage target",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Description:Fundamental operation in an Information System (IS) that results only in the act of bringing an object into existence. Note: The preceding definition is taken from the HL7 RBAC specification.  There is no restriction on how the operation is invoked, e.g., via a user interface. For an HL7 Act, the state transitions per the HL7 Reference Information Model.
    /// </summary>
    public static readonly Coding Create_v3_DataOperation = new Coding
    {
      Code = "CREATE",
      Display = "create",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// Participant material that is taken up, diminished, altered, or disappears in the act.
    /// </summary>
    public static readonly Coding Consumable_v3_ParticipationType = new Coding
    {
      Code = "CSM",
      Display = "consumable",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// An entity (person, organization or device) that is in charge of maintaining the information of this act (e.g., who maintains the report or the master service catalog item, etc.).
    /// </summary>
    public static readonly Coding Custodian_v3_ParticipationType = new Coding
    {
      Code = "CST",
      Display = "custodian",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Custodian system must strip information of data that would allow the identification of the source of the information or the information subject.
    /// </summary>
    public static readonly Coding Deidentify_v3_ActCode = new Coding
    {
      Code = "DEID",
      Display = "deidentify",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Description:Fundamental operation in an Information System (IS) that results only in the removal of information about an object from memory or storage. Note: The preceding definition is taken from the HL7 RBAC specification.  There is no restriction on how the operation is invoked, e.g., via a user interface.
    /// </summary>
    public static readonly Coding Delete_v3_DataOperation = new Coding
    {
      Code = "DELETE",
      Display = "delete",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// Participant used in performing the act without being substantially affected by the act (i.e. durable or inert with respect to that particular service).
    /// 
    ///                         
    ///                            Examples: monitoring equipment, tools, but also access/drainage lines, prostheses, pace maker, etc.
    /// </summary>
    public static readonly Coding Device_v3_ParticipationType = new Coding
    {
      Code = "DEV",
      Display = "device",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Target participant  that is substantially present in the act  and which is directly involved in the action (includes consumed material, devices, etc.).
    /// </summary>
    public static readonly Coding DirectTarget_v3_ParticipationType = new Coding
    {
      Code = "DIR",
      Display = "direct target",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// The practitioner who is responsible for the discharge of a patient from a patient encounter.
    /// </summary>
    public static readonly Coding Discharger_v3_ParticipationType = new Coding
    {
      Code = "DIS",
      Display = "discharger",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Distributes material used in or generated during the act.
    /// </summary>
    public static readonly Coding Distributor_v3_ParticipationType = new Coding
    {
      Code = "DIST",
      Display = "distributor",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// In some organ transplantation services and rarely in transfusion services a donor will be a target participant in the service.  However, in most cases transplantation is decomposed in three services: explantation, transport, and implantation.  The identity of the donor (recipient) is often irrelevant for the explantation (implantation) service.
    /// </summary>
    public static readonly Coding Donor_v3_ParticipationType = new Coding
    {
      Code = "DON",
      Display = "donor",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// The destination for services.  May be a static building (or room therein) or a movable facility (e.g., ship).
    /// </summary>
    public static readonly Coding Destination_v3_ParticipationType = new Coding
    {
      Code = "DST",
      Display = "destination",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A location where data about an Act was entered.
    /// </summary>
    public static readonly Coding EntryLocation_v3_ParticipationType = new Coding
    {
      Code = "ELOC",
      Display = "entry location",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A person entering the data into the originating system.  The data entry person is collected optionally for internal quality control purposes.  This includes the transcriptionist for dictated text.
    /// </summary>
    public static readonly Coding DataEntryPerson_v3_ParticipationType = new Coding
    {
      Code = "ENT",
      Display = "data entry person",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Only with Transportation services.  A person who escorts the patient.
    /// </summary>
    public static readonly Coding Escort_v3_ParticipationType = new Coding
    {
      Code = "ESC",
      Display = "escort",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Description: The entity playing the associated role is the physical (including energy), chemical or biological substance that is participating in the exposure.  For example in communicable diseases, the associated playing entity is the disease causing pathogen.
    /// </summary>
    public static readonly Coding ExposureAgent_v3_ParticipationType = new Coding
    {
      Code = "EXPAGNT",
      Display = "ExposureAgent",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Description:Direct participation in an exposure act where it is unknown that the participant is the source or subject of the exposure.  If the participant is known to be the contact of an exposure then the SBJ participation type should be used.  If the participant is known to be the source then the EXSRC participation type should be used.
    /// </summary>
    public static readonly Coding ExposureParticipation_v3_ParticipationType = new Coding
    {
      Code = "EXPART",
      Display = "ExposureParticipation",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Description: The entity playing the associated role is the target (contact) of exposure.
    /// </summary>
    public static readonly Coding ExposureTarget_v3_ParticipationType = new Coding
    {
      Code = "EXPTRGT",
      Display = "ExposureTarget",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Description:The entity playing the associated role is the source of exposure.
    /// </summary>
    public static readonly Coding ExposureSource_v3_ParticipationType = new Coding
    {
      Code = "EXSRC",
      Display = "ExposureSource",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// The target person or organization contractually recognized by the issuer as a participant who has assumed fiscal responsibility for another personaTMs financial obligations by guaranteeing to pay for amounts owed to a particular account
    /// 
    ///                         
    ///                            Example:The subscriber of the patientaTMs health insurance policy signs a contract with the provider to be fiscally responsible for the patient billing account balance amount owed.
    /// </summary>
    public static readonly Coding GuarantorParty_v3_ParticipationType = new Coding
    {
      Code = "GUAR",
      Display = "guarantor party",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Participant who posses an instrument such as a financial contract (insurance policy) usually based on some agreement with the author.
    /// </summary>
    public static readonly Coding Holder_v3_ParticipationType = new Coding
    {
      Code = "HLD",
      Display = "holder",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Target that is not substantially present in the act and which is not directly affected by the act, but which will be a focus of the record or documentation of the act.
    /// </summary>
    public static readonly Coding IndirectTarget_v3_ParticipationType = new Coding
    {
      Code = "IND",
      Display = "indirect target",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A source of reported information (e.g., a next of kin who answers questions about the patient's history).  For history questions, the patient is logically an informant, yet the informant of history questions is implicitly the subject.
    /// </summary>
    public static readonly Coding Informant_v3_ParticipationType = new Coding
    {
      Code = "INF",
      Display = "informant",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A party, who may or should receive or who has recieved the Act or subsequent or derivative information of that Act. Information recipient is inert, i.e., independent of mood." Rationale: this is a generalization of a too diverse family that the definition can't be any more specific, and the concept is abstract so one of the specializations should be used.
    /// </summary>
    public static readonly Coding InformationRecipient_v3_ParticipationType = new Coding
    {
      Code = "IRCP",
      Display = "information recipient",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A completion status in which a document has been signed manually or electronically by the individual who is legally responsible for that document. This is the most mature state in the workflow progression.
    /// </summary>
    public static readonly Coding LegallyAuthenticated_v3_DocumentCompletion = new Coding
    {
      Code = "LA",
      Display = "legally authenticated",
      System = "http://terminology.hl7.org/CodeSystem/v3-DocumentCompletion"
    };
    /// <summary>
    /// A verifier who legally authenticates the accuracy of an act. An example would be a staff physician who sees a patient and dictates a note, then later signs it. Their signature constitutes a legal authentication.
    /// </summary>
    public static readonly Coding LegalAuthenticator_v3_ParticipationType = new Coding
    {
      Code = "LA",
      Display = "legal authenticator",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Custodian security system must assign and bind security labels in order to classify information created in the information systems under its control for collection, access, use and disclosure in accordance with applicable jurisdictional privacy policies associated with the target information. The system must retain an immutable record of the assignment and binding.
    /// 
    ///                         
    ///                            Usage Note: In security systems, security policy label assignments do not change, they may supersede prior assignments, and such reassignments are always tracked for auditing and other purposes.
    /// </summary>
    public static readonly Coding AssignSecurityLabel_v3_ActCode = new Coding
    {
      Code = "LABEL",
      Display = "assign security label",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// The facility where the service is done.  May be a static building (or room therein) or a moving location (e.g., ambulance, helicopter, aircraft, train, truck, ship, etc.)
    /// </summary>
    public static readonly Coding Location_v3_ParticipationType = new Coding
    {
      Code = "LOC",
      Display = "location",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Custodian system must render information unreadable and unusable by algorithmically transforming plaintext into ciphertext.  User may be provided a key to decrypt per license or "shared secret".
    /// </summary>
    public static readonly Coding Mask_v3_ActCode = new Coding
    {
      Code = "MASK",
      Display = "mask",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// An information recipient to notify for urgent matters about this Act. (e.g., in a laboratory order, critical results are being called by phone right away, this is the contact to call; or for an inpatient encounter, a next of kin to notify when the patient becomes critically ill).
    /// </summary>
    public static readonly Coding UgentNotificationContact_v3_ParticipationType = new Coding
    {
      Code = "NOT",
      Display = "ugent notification contact",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A device that changes ownership due to the service, e.g., a pacemaker, a prosthesis, an insulin injection equipment (pen), etc.  Such material may need to be restocked after he service.
    /// </summary>
    public static readonly Coding NonReuseableDevice_v3_ParticipationType = new Coding
    {
      Code = "NRD",
      Display = "non-reuseable device",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Description:Change the status of an object representing an Act to "nullified", i.e., treat as though it never existed. For an HL7 Act, the state transitions per the HL7 Reference Information Model.
    /// </summary>
    public static readonly Coding Nullify_v3_DataOperation = new Coding
    {
      Code = "NULLIFY",
      Display = "nullify",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// The location of origin for services.  May be a static building (or room therein) or a movable facility (e.g., ship).
    /// </summary>
    public static readonly Coding Origin_v3_ParticipationType = new Coding
    {
      Code = "ORG",
      Display = "origin",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Indicates that the target of the participation is involved in some manner in the act, but does not qualify how.
    /// </summary>
    public static readonly Coding Participation_v3_ParticipationType = new Coding
    {
      Code = "PART",
      Display = "Participation",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// The principal or primary performer of the act.
    /// </summary>
    public static readonly Coding PrimaryPerformer_v3_ParticipationType = new Coding
    {
      Code = "PPRF",
      Display = "primary performer",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Information recipient to whom an act statement is primarily directed. E.g., a primary care provider receiving a discharge letter from a hospitalist, a health department receiving information on a suspected case of infectious disease. Multiple of these participations may exist on the same act without requiring that recipients be ranked as primary vs. secondary.
    /// </summary>
    public static readonly Coding PrimaryInformationRecipient_v3_ParticipationType = new Coding
    {
      Code = "PRCP",
      Display = "primary information recipient",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Participant material that is brought forth (produced) in the act (e.g., specimen in a specimen collection, access or drainage in a placement service, medication package in a dispense service). It does not matter whether the material produced had existence prior to the service, or whether it is created in the service (e.g., in supply services the product is taken from a stock).
    /// </summary>
    public static readonly Coding Product_v3_ParticipationType = new Coding
    {
      Code = "PRD",
      Display = "product",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Definition: A person, non-person living subject, organization or device that who actually and principally carries out the action. Device should only be assigned as a performer in circumstances where the device is performing independent of human intervention.  Need not be the principal responsible actor.
    /// 
    ///                         
    ///                            Exampe: A surgery resident operating under supervision of attending surgeon, a search and rescue dog locating survivors, an electronic laboratory analyzer or the laboratory discipline requested to perform a laboratory test. The performer may also be the patient in self-care, e.g. fingerstick blood sugar. The traditional order filler is a performer. This information should accompany every service event.
    /// 
    ///                         
    ///                            Note: that existing HL7 designs assign an organization as the playing entity of the Role that is the performer.  These designs should be revised in subsequent releases to make this the scooping entity for the role involved.
    /// </summary>
    public static readonly Coding Performer_v3_ParticipationType = new Coding
    {
      Code = "PRF",
      Display = "performer",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Custodian system must strip information of data that would allow the identification of the source of the information or the information subject.  Custodian may retain a key to relink data necessary to reidentify the information subject.
    /// </summary>
    public static readonly Coding Pseudonymize_v3_ActCode = new Coding
    {
      Code = "PSEUD",
      Display = "pseudonymize",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// The record target indicates whose medical record holds the documentation of this act.  This is especially important when the subject of a service is not the patient himself.
    /// </summary>
    public static readonly Coding RecordTarget_v3_ParticipationType = new Coding
    {
      Code = "RCT",
      Display = "record target",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// The person (or organization) who receives the product of an Act.
    /// </summary>
    public static readonly Coding Receiver_v3_ParticipationType = new Coding
    {
      Code = "RCV",
      Display = "receiver",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A device that does not change ownership due to the service, i.e., a surgical instrument or tool or an endoscope.  The distinction between reuseable and non-reuseable must be made in order to know whether material must be re-stocked.
    /// </summary>
    public static readonly Coding ReusableDevice_v3_ParticipationType = new Coding
    {
      Code = "RDV",
      Display = "reusable device",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A person having referred the subject of the service to the performer (referring physician).  Typically, a referring physician will receive a report.
    /// </summary>
    public static readonly Coding Referrer_v3_ParticipationType = new Coding
    {
      Code = "REF",
      Display = "referrer",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A participant (e.g. provider) who has referred the subject of an act (e.g. patient).
    /// 
    ///                         Typically, a referred by participant will provide a report (e.g. referral).
    /// </summary>
    public static readonly Coding ReferredBy_v3_ParticipationType = new Coding
    {
      Code = "REFB",
      Display = "Referred By",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// The person who receives the patient
    /// </summary>
    public static readonly Coding ReferredTo_v3_ParticipationType = new Coding
    {
      Code = "REFT",
      Display = "Referred to",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// The person or organization that has primary responsibility for the act.  The responsible party is not necessarily present in an action, but is accountable for the action through the power to delegate, and the duty to review actions with the performing actor after the fact.  This responsibility may be ethical, legal, contractual, fiscal, or fiduciary in nature.
    /// 
    ///                         
    ///                            Example: A person who is the head of a biochemical laboratory; a sponsor for a policy or government program.
    /// </summary>
    public static readonly Coding ResponsibleParty_v3_ParticipationType = new Coding
    {
      Code = "RESP",
      Display = "responsible party",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Some services take place at multiple concurrent locations (e.g., telemedicine, telephone consultation).  The location where the principal performing actor is located is taken as the primary location (LOC) while the other location(s) are considered "remote."
    /// </summary>
    public static readonly Coding Remote_v3_ParticipationType = new Coding
    {
      Code = "RML",
      Display = "remote",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// The principle target on which the action happens.
    /// 
    ///                         
    ///                            Examples: The patient in physical examination, a specimen in a lab observation. May also be a patient's family member (teaching) or a device or room (cleaning, disinfecting, housekeeping). 
    /// 
    ///                         
    ///                            UsageNotes: Not all direct targets are subjects. Consumables and devices used as tools for an act are not subjects. However, a device may be a subject of a maintenance action.
    /// </summary>
    public static readonly Coding Subject_v3_ParticipationType = new Coding
    {
      Code = "SBJ",
      Display = "subject",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// The subject of non-clinical (e.g. laboratory) observation services is a specimen.
    /// </summary>
    public static readonly Coding Specimen_v3_ParticipationType = new Coding
    {
      Code = "SPC",
      Display = "specimen",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A person assisting in an act through his substantial presence and involvement   This includes: assistants, technicians, associates, or whatever the job titles may be.
    /// </summary>
    public static readonly Coding SecondaryPerformer_v3_ParticipationType = new Coding
    {
      Code = "SPRF",
      Display = "secondary performer",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Something incorporated in the subject of a therapy service to achieve a physiologic effect (e.g., heal, relieve, provoke a condition, etc.) on the subject.  In an administration service the therapeutic agent is a consumable, in a preparation or dispense service, it is a product.  Thus, consumable or product must be specified in accordance with the kind of service.
    /// </summary>
    public static readonly Coding TherapeuticAgent_v3_ParticipationType = new Coding
    {
      Code = "TPA",
      Display = "therapeutic agent",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// An entity entering the data into the originating system. The data entry entity is collected optionally for internal quality control purposes. This includes the transcriptionist for dictated text transcribed into electronic form.
    /// </summary>
    public static readonly Coding Transcriber_v3_ParticipationType = new Coding
    {
      Code = "TRANS",
      Display = "Transcriber",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A secondary information recipient, who receives copies (e.g., a primary care provider receiving copies of results as ordered by specialist).
    /// </summary>
    public static readonly Coding Tracker_v3_ParticipationType = new Coding
    {
      Code = "TRC",
      Display = "tracker",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Definition:Fundamental operation in an Information System (IS) that results only in the revision or alteration of an object. Note: The preceding definition is taken from the HL7 RBAC specification. There is no restriction on how the operation is invoked, e.g., via a user interface.
    /// </summary>
    public static readonly Coding Revise_v3_DataOperation = new Coding
    {
      Code = "UPDATE",
      Display = "revise",
      System = "http://terminology.hl7.org/CodeSystem/v3-DataOperation"
    };
    /// <summary>
    /// For services, an intermediate location that specifies a path between origin an destination.
    /// </summary>
    public static readonly Coding Via_v3_ParticipationType = new Coding
    {
      Code = "VIA",
      Display = "via",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// A person who verifies the correctness and appropriateness of the service (plan, order, event, etc.) and hence takes on accountability.
    /// </summary>
    public static readonly Coding Verifier_v3_ParticipationType = new Coding
    {
      Code = "VRF",
      Display = "verifier",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
    /// <summary>
    /// Only with service events.  A person witnessing the action happening without doing anything.  A witness is not necessarily aware, much less approves of anything stated in the service event.  Example for a witness is students watching an operation or an advanced directive witness.
    /// </summary>
    public static readonly Coding Witness_v3_ParticipationType = new Coding
    {
      Code = "WIT",
      Display = "witness",
      System = "http://terminology.hl7.org/CodeSystem/v3-ParticipationType"
    };
  };
}
