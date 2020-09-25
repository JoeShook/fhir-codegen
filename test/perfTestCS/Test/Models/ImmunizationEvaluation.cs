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
  /// Describes a comparison of an immunization event against published recommendations to determine if the administration is "valid" in relation to those  recommendations.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonResourceConverter))]
  public class ImmunizationEvaluation : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "ImmunizationEvaluation";
    /// <summary>
    /// Indicates the authority who published the protocol (e.g. ACIP).
    /// </summary>
    public Reference Authority { get; set; }
    /// <summary>
    /// The date the evaluation of the vaccine administration event was performed.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// Additional information about the evaluation.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// The use of an integer is preferred if known. A string should only be used in cases where an integer is not available (such as when documenting a recurring booster dose).
    /// </summary>
    public uint? DoseNumberPositiveInt { get; set; }
    /// <summary>
    /// The use of an integer is preferred if known. A string should only be used in cases where an integer is not available (such as when documenting a recurring booster dose).
    /// </summary>
    public string DoseNumberString { get; set; }
    /// <summary>
    /// Extension container element for DoseNumberString
    /// </summary>
    public Element _DoseNumberString { get; set; }
    /// <summary>
    /// Indicates if the dose is valid or not valid with respect to the published recommendations.
    /// </summary>
    public CodeableConcept DoseStatus { get; set; }
    /// <summary>
    /// Provides an explanation as to why the vaccine administration event is valid or not relative to the published recommendations.
    /// </summary>
    public List<CodeableConcept> DoseStatusReason { get; set; }
    /// <summary>
    /// A unique identifier assigned to this immunization evaluation record.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The vaccine administration event being evaluated.
    /// </summary>
    public Reference ImmunizationEvent { get; set; }
    /// <summary>
    /// The individual for whom the evaluation is being done.
    /// </summary>
    public Reference Patient { get; set; }
    /// <summary>
    /// One possible path to achieve presumed immunity against a disease - within the context of an authority.
    /// </summary>
    public string Series { get; set; }
    /// <summary>
    /// Extension container element for Series
    /// </summary>
    public Element _Series { get; set; }
    /// <summary>
    /// The use of an integer is preferred if known. A string should only be used in cases where an integer is not available (such as when documenting a recurring booster dose).
    /// </summary>
    public uint? SeriesDosesPositiveInt { get; set; }
    /// <summary>
    /// The use of an integer is preferred if known. A string should only be used in cases where an integer is not available (such as when documenting a recurring booster dose).
    /// </summary>
    public string SeriesDosesString { get; set; }
    /// <summary>
    /// Extension container element for SeriesDosesString
    /// </summary>
    public Element _SeriesDosesString { get; set; }
    /// <summary>
    /// Indicates the current status of the evaluation of the vaccination administration event.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The vaccine preventable disease the dose is being evaluated against.
    /// </summary>
    public CodeableConcept TargetDisease { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "authority":
          Authority = new Fhir.R4.Models.Reference();
          Authority.DeserializeJson(ref reader, options);
          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new Fhir.R4.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new Fhir.R4.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "doseNumberPositiveInt":
          DoseNumberPositiveInt = reader.GetUInt32();
          break;

        case "doseNumberString":
          DoseNumberString = reader.GetString();
          break;

        case "_doseNumberString":
          _DoseNumberString = new Fhir.R4.Models.Element();
          _DoseNumberString.DeserializeJson(ref reader, options);
          break;

        case "doseStatus":
          DoseStatus = new Fhir.R4.Models.CodeableConcept();
          DoseStatus.DeserializeJson(ref reader, options);
          break;

        case "doseStatusReason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DoseStatusReason = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objDoseStatusReason = new Fhir.R4.Models.CodeableConcept();
            objDoseStatusReason.DeserializeJson(ref reader, options);
            DoseStatusReason.Add(objDoseStatusReason);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DoseStatusReason.Count == 0)
          {
            DoseStatusReason = null;
          }

          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Identifier objIdentifier = new Fhir.R4.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "immunizationEvent":
          ImmunizationEvent = new Fhir.R4.Models.Reference();
          ImmunizationEvent.DeserializeJson(ref reader, options);
          break;

        case "patient":
          Patient = new Fhir.R4.Models.Reference();
          Patient.DeserializeJson(ref reader, options);
          break;

        case "series":
          Series = reader.GetString();
          break;

        case "_series":
          _Series = new Fhir.R4.Models.Element();
          _Series.DeserializeJson(ref reader, options);
          break;

        case "seriesDosesPositiveInt":
          SeriesDosesPositiveInt = reader.GetUInt32();
          break;

        case "seriesDosesString":
          SeriesDosesString = reader.GetString();
          break;

        case "_seriesDosesString":
          _SeriesDosesString = new Fhir.R4.Models.Element();
          _SeriesDosesString.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "targetDisease":
          TargetDisease = new Fhir.R4.Models.CodeableConcept();
          TargetDisease.DeserializeJson(ref reader, options);
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
