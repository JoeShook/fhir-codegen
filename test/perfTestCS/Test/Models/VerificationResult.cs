// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Fhir.R4.ValueSets;
using Fhir.R4.Serialization;

namespace Fhir.R4.Models
{
  /// <summary>
  /// Information about the primary source(s) involved in validation.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<VerificationResultPrimarySource>))]
  public class VerificationResultPrimarySource : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Ability of the primary source to push updates/alerts (yes; no; undetermined).
    /// </summary>
    public CodeableConcept CanPushUpdates { get; set; }
    /// <summary>
    /// Method for communicating with the primary source (manual; API; Push).
    /// </summary>
    public List<CodeableConcept> CommunicationMethod { get; set; }
    /// <summary>
    /// Type of alerts/updates the primary source can send (specific requested changes; any changes; as defined by source).
    /// </summary>
    public List<CodeableConcept> PushTypeAvailable { get; set; }
    /// <summary>
    /// Type of primary source (License Board; Primary Education; Continuing Education; Postal Service; Relationship owner; Registration Authority; legal source; issuing source; authoritative source).
    /// </summary>
    public List<CodeableConcept> Type { get; set; }
    /// <summary>
    /// When the target was validated against the primary source.
    /// </summary>
    public string ValidationDate { get; set; }
    /// <summary>
    /// Extension container element for ValidationDate
    /// </summary>
    public Element _ValidationDate { get; set; }
    /// <summary>
    /// Status of the validation of the target against the primary source (successful; failed; unknown).
    /// </summary>
    public CodeableConcept ValidationStatus { get; set; }
    /// <summary>
    /// Reference to the primary source.
    /// </summary>
    public Reference Who { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "canPushUpdates":
          CanPushUpdates = new Fhir.R4.Models.CodeableConcept();
          CanPushUpdates.DeserializeJson(ref reader, options);
          break;

        case "communicationMethod":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          CommunicationMethod = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objCommunicationMethod = new Fhir.R4.Models.CodeableConcept();
            objCommunicationMethod.DeserializeJson(ref reader, options);
            CommunicationMethod.Add(objCommunicationMethod);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (CommunicationMethod.Count == 0)
          {
            CommunicationMethod = null;
          }

          break;

        case "pushTypeAvailable":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PushTypeAvailable = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objPushTypeAvailable = new Fhir.R4.Models.CodeableConcept();
            objPushTypeAvailable.DeserializeJson(ref reader, options);
            PushTypeAvailable.Add(objPushTypeAvailable);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PushTypeAvailable.Count == 0)
          {
            PushTypeAvailable = null;
          }

          break;

        case "type":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Type = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objType = new Fhir.R4.Models.CodeableConcept();
            objType.DeserializeJson(ref reader, options);
            Type.Add(objType);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Type.Count == 0)
          {
            Type = null;
          }

          break;

        case "validationDate":
          ValidationDate = reader.GetString();
          break;

        case "_validationDate":
          _ValidationDate = new Fhir.R4.Models.Element();
          _ValidationDate.DeserializeJson(ref reader, options);
          break;

        case "validationStatus":
          ValidationStatus = new Fhir.R4.Models.CodeableConcept();
          ValidationStatus.DeserializeJson(ref reader, options);
          break;

        case "who":
          Who = new Fhir.R4.Models.Reference();
          Who.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Information about the entity attesting to information.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<VerificationResultAttestation>))]
  public class VerificationResultAttestation : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The method by which attested information was submitted/retrieved (manual; API; Push).
    /// </summary>
    public CodeableConcept CommunicationMethod { get; set; }
    /// <summary>
    /// The date the information was attested to.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// When the who is asserting on behalf of another (organization or individual).
    /// </summary>
    public Reference OnBehalfOf { get; set; }
    /// <summary>
    /// A digital identity certificate associated with the proxy entity submitting attested information on behalf of the attestation source.
    /// </summary>
    public string ProxyIdentityCertificate { get; set; }
    /// <summary>
    /// Extension container element for ProxyIdentityCertificate
    /// </summary>
    public Element _ProxyIdentityCertificate { get; set; }
    /// <summary>
    /// Signed assertion by the proxy entity indicating that they have the right to submit attested information on behalf of the attestation source.
    /// </summary>
    public Signature ProxySignature { get; set; }
    /// <summary>
    /// A digital identity certificate associated with the attestation source.
    /// </summary>
    public string SourceIdentityCertificate { get; set; }
    /// <summary>
    /// Extension container element for SourceIdentityCertificate
    /// </summary>
    public Element _SourceIdentityCertificate { get; set; }
    /// <summary>
    /// Signed assertion by the attestation source that they have attested to the information.
    /// </summary>
    public Signature SourceSignature { get; set; }
    /// <summary>
    /// The individual or organization attesting to information.
    /// </summary>
    public Reference Who { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "communicationMethod":
          CommunicationMethod = new Fhir.R4.Models.CodeableConcept();
          CommunicationMethod.DeserializeJson(ref reader, options);
          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new Fhir.R4.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "onBehalfOf":
          OnBehalfOf = new Fhir.R4.Models.Reference();
          OnBehalfOf.DeserializeJson(ref reader, options);
          break;

        case "proxyIdentityCertificate":
          ProxyIdentityCertificate = reader.GetString();
          break;

        case "_proxyIdentityCertificate":
          _ProxyIdentityCertificate = new Fhir.R4.Models.Element();
          _ProxyIdentityCertificate.DeserializeJson(ref reader, options);
          break;

        case "proxySignature":
          ProxySignature = new Fhir.R4.Models.Signature();
          ProxySignature.DeserializeJson(ref reader, options);
          break;

        case "sourceIdentityCertificate":
          SourceIdentityCertificate = reader.GetString();
          break;

        case "_sourceIdentityCertificate":
          _SourceIdentityCertificate = new Fhir.R4.Models.Element();
          _SourceIdentityCertificate.DeserializeJson(ref reader, options);
          break;

        case "sourceSignature":
          SourceSignature = new Fhir.R4.Models.Signature();
          SourceSignature.DeserializeJson(ref reader, options);
          break;

        case "who":
          Who = new Fhir.R4.Models.Reference();
          Who.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Information about the entity validating information.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<VerificationResultValidator>))]
  public class VerificationResultValidator : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Signed assertion by the validator that they have validated the information.
    /// </summary>
    public Signature AttestationSignature { get; set; }
    /// <summary>
    /// A digital identity certificate associated with the validator.
    /// </summary>
    public string IdentityCertificate { get; set; }
    /// <summary>
    /// Extension container element for IdentityCertificate
    /// </summary>
    public Element _IdentityCertificate { get; set; }
    /// <summary>
    /// Reference to the organization validating information.
    /// </summary>
    public Reference Organization { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "attestationSignature":
          AttestationSignature = new Fhir.R4.Models.Signature();
          AttestationSignature.DeserializeJson(ref reader, options);
          break;

        case "identityCertificate":
          IdentityCertificate = reader.GetString();
          break;

        case "_identityCertificate":
          _IdentityCertificate = new Fhir.R4.Models.Element();
          _IdentityCertificate.DeserializeJson(ref reader, options);
          break;

        case "organization":
          Organization = new Fhir.R4.Models.Reference();
          Organization.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Describes validation requirements, source(s), status and dates for one or more elements.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonResourceConverter))]
  public class VerificationResult : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "VerificationResult";
    /// <summary>
    /// Information about the entity attesting to information.
    /// </summary>
    public VerificationResultAttestation Attestation { get; set; }
    /// <summary>
    /// The result if validation fails (fatal; warning; record only; none).
    /// </summary>
    public CodeableConcept FailureAction { get; set; }
    /// <summary>
    /// Frequency of revalidation.
    /// </summary>
    public Timing Frequency { get; set; }
    /// <summary>
    /// The date/time validation was last completed (including failed validations).
    /// </summary>
    public string LastPerformed { get; set; }
    /// <summary>
    /// Extension container element for LastPerformed
    /// </summary>
    public Element _LastPerformed { get; set; }
    /// <summary>
    /// The frequency with which the target must be validated (none; initial; periodic).
    /// </summary>
    public CodeableConcept Need { get; set; }
    /// <summary>
    /// The date when target is next validated, if appropriate.
    /// </summary>
    public string NextScheduled { get; set; }
    /// <summary>
    /// Extension container element for NextScheduled
    /// </summary>
    public Element _NextScheduled { get; set; }
    /// <summary>
    /// Information about the primary source(s) involved in validation.
    /// </summary>
    public List<VerificationResultPrimarySource> PrimarySource { get; set; }
    /// <summary>
    /// The validation status of the target (attested; validated; in process; requires revalidation; validation failed; revalidation failed).
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// When the validation status was updated.
    /// </summary>
    public string StatusDate { get; set; }
    /// <summary>
    /// Extension container element for StatusDate
    /// </summary>
    public Element _StatusDate { get; set; }
    /// <summary>
    /// A resource that was validated.
    /// </summary>
    public List<Reference> Target { get; set; }
    /// <summary>
    /// The fhirpath location(s) within the resource that was validated.
    /// </summary>
    public List<string> TargetLocation { get; set; }
    /// <summary>
    /// Extension container element for TargetLocation
    /// </summary>
    public List<Element> _TargetLocation { get; set; }
    /// <summary>
    /// The primary process by which the target is validated (edit check; value set; primary source; multiple sources; standalone; in context).
    /// </summary>
    public List<CodeableConcept> ValidationProcess { get; set; }
    /// <summary>
    /// What the target is validated against (nothing; primary source; multiple sources).
    /// </summary>
    public CodeableConcept ValidationType { get; set; }
    /// <summary>
    /// Information about the entity validating information.
    /// </summary>
    public List<VerificationResultValidator> Validator { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "attestation":
          Attestation = new Fhir.R4.Models.VerificationResultAttestation();
          Attestation.DeserializeJson(ref reader, options);
          break;

        case "failureAction":
          FailureAction = new Fhir.R4.Models.CodeableConcept();
          FailureAction.DeserializeJson(ref reader, options);
          break;

        case "frequency":
          Frequency = new Fhir.R4.Models.Timing();
          Frequency.DeserializeJson(ref reader, options);
          break;

        case "lastPerformed":
          LastPerformed = reader.GetString();
          break;

        case "_lastPerformed":
          _LastPerformed = new Fhir.R4.Models.Element();
          _LastPerformed.DeserializeJson(ref reader, options);
          break;

        case "need":
          Need = new Fhir.R4.Models.CodeableConcept();
          Need.DeserializeJson(ref reader, options);
          break;

        case "nextScheduled":
          NextScheduled = reader.GetString();
          break;

        case "_nextScheduled":
          _NextScheduled = new Fhir.R4.Models.Element();
          _NextScheduled.DeserializeJson(ref reader, options);
          break;

        case "primarySource":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PrimarySource = new List<VerificationResultPrimarySource>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.VerificationResultPrimarySource objPrimarySource = new Fhir.R4.Models.VerificationResultPrimarySource();
            objPrimarySource.DeserializeJson(ref reader, options);
            PrimarySource.Add(objPrimarySource);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PrimarySource.Count == 0)
          {
            PrimarySource = null;
          }

          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "statusDate":
          StatusDate = reader.GetString();
          break;

        case "_statusDate":
          _StatusDate = new Fhir.R4.Models.Element();
          _StatusDate.DeserializeJson(ref reader, options);
          break;

        case "target":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Target = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objTarget = new Fhir.R4.Models.Reference();
            objTarget.DeserializeJson(ref reader, options);
            Target.Add(objTarget);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Target.Count == 0)
          {
            Target = null;
          }

          break;

        case "targetLocation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          TargetLocation = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            TargetLocation.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (TargetLocation.Count == 0)
          {
            TargetLocation = null;
          }

          break;

        case "_targetLocation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _TargetLocation = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Element obj_TargetLocation = new Fhir.R4.Models.Element();
            obj_TargetLocation.DeserializeJson(ref reader, options);
            _TargetLocation.Add(obj_TargetLocation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_TargetLocation.Count == 0)
          {
            _TargetLocation = null;
          }

          break;

        case "validationProcess":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ValidationProcess = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objValidationProcess = new Fhir.R4.Models.CodeableConcept();
            objValidationProcess.DeserializeJson(ref reader, options);
            ValidationProcess.Add(objValidationProcess);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ValidationProcess.Count == 0)
          {
            ValidationProcess = null;
          }

          break;

        case "validationType":
          ValidationType = new Fhir.R4.Models.CodeableConcept();
          ValidationType.DeserializeJson(ref reader, options);
          break;

        case "validator":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Validator = new List<VerificationResultValidator>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.VerificationResultValidator objValidator = new Fhir.R4.Models.VerificationResultValidator();
            objValidator.DeserializeJson(ref reader, options);
            Validator.Add(objValidator);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Validator.Count == 0)
          {
            Validator = null;
          }

          break;

        default:
          ((Fhir.R4.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
}
