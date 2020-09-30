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
  /// A guidance response is the formal response to a guidance request, including any output parameters returned by the evaluation, as well as the description of any proposed actions to be taken.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<GuidanceResponse>))]
  public class GuidanceResponse : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "GuidanceResponse";
    /// <summary>
    /// If the evaluation could not be completed due to lack of information, or additional information would potentially result in a more accurate response, this element will a description of the data required in order to proceed with the evaluation. A subsequent request to the service should include this data.
    /// </summary>
    public List<DataRequirement> DataRequirement { get; set; }
    /// <summary>
    /// This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official copmletion of an encounter but still be tied to the context of the encounter.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// Messages resulting from the evaluation of the artifact or artifacts. As part of evaluating the request, the engine may produce informational or warning messages. These messages will be provided by this element.
    /// </summary>
    public List<Reference> EvaluationMessage { get; set; }
    /// <summary>
    /// Allows a service to provide  unique, business identifiers for the response.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// An identifier, CodeableConcept or canonical reference to the guidance that was requested.
    /// </summary>
    public string ModuleUri { get; set; }
    /// <summary>
    /// Extension container element for ModuleUri
    /// </summary>
    public Element _ModuleUri { get; set; }
    /// <summary>
    /// An identifier, CodeableConcept or canonical reference to the guidance that was requested.
    /// </summary>
    public string ModuleCanonical { get; set; }
    /// <summary>
    /// Extension container element for ModuleCanonical
    /// </summary>
    public Element _ModuleCanonical { get; set; }
    /// <summary>
    /// An identifier, CodeableConcept or canonical reference to the guidance that was requested.
    /// </summary>
    public CodeableConcept ModuleCodeableConcept { get; set; }
    /// <summary>
    /// Provides a mechanism to communicate additional information about the response.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// Indicates when the guidance response was processed.
    /// </summary>
    public string OccurrenceDateTime { get; set; }
    /// <summary>
    /// Extension container element for OccurrenceDateTime
    /// </summary>
    public Element _OccurrenceDateTime { get; set; }
    /// <summary>
    /// The output parameters of the evaluation, if any. Many modules will result in the return of specific resources such as procedure or communication requests that are returned as part of the operation result. However, modules may define specific outputs that would be returned as the result of the evaluation, and these would be returned in this element.
    /// </summary>
    public Reference OutputParameters { get; set; }
    /// <summary>
    /// Provides a reference to the device that performed the guidance.
    /// </summary>
    public Reference Performer { get; set; }
    /// <summary>
    /// Describes the reason for the guidance response in coded or textual form.
    /// </summary>
    public List<CodeableConcept> ReasonCode { get; set; }
    /// <summary>
    /// Indicates the reason the request was initiated. This is typically provided as a parameter to the evaluation and echoed by the service, although for some use cases, such as subscription- or event-based scenarios, it may provide an indication of the cause for the response.
    /// </summary>
    public List<Reference> ReasonReference { get; set; }
    /// <summary>
    /// The identifier of the request associated with this response. If an identifier was given as part of the request, it will be reproduced here to enable the requester to more easily identify the response in a multi-request scenario.
    /// </summary>
    public Identifier RequestIdentifier { get; set; }
    /// <summary>
    /// The actions, if any, produced by the evaluation of the artifact.
    /// </summary>
    public Reference Result { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The patient for which the request was processed.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(ref Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((Fhir.R4.Models.DomainResource)this).SerializeJson(ref writer, options, false);

      if (RequestIdentifier != null)
      {
        writer.WritePropertyName("requestIdentifier");
        RequestIdentifier.SerializeJson(ref writer, options);
      }

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(ModuleUri))
      {
        writer.WriteString("moduleUri", (string)ModuleUri!);
      }

      if (_ModuleUri != null)
      {
        writer.WritePropertyName("_moduleUri");
        _ModuleUri.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(ModuleCanonical))
      {
        writer.WriteString("moduleCanonical", (string)ModuleCanonical!);
      }

      if (_ModuleCanonical != null)
      {
        writer.WritePropertyName("_moduleCanonical");
        _ModuleCanonical.SerializeJson(ref writer, options);
      }

      writer.WritePropertyName("moduleCodeableConcept");
      ModuleCodeableConcept.SerializeJson(ref writer, options);

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(ref writer, options);
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(ref writer, options);
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(OccurrenceDateTime))
      {
        writer.WriteString("occurrenceDateTime", (string)OccurrenceDateTime!);
      }

      if (_OccurrenceDateTime != null)
      {
        writer.WritePropertyName("_occurrenceDateTime");
        _OccurrenceDateTime.SerializeJson(ref writer, options);
      }

      if (Performer != null)
      {
        writer.WritePropertyName("performer");
        Performer.SerializeJson(ref writer, options);
      }

      if ((ReasonCode != null) && (ReasonCode.Count != 0))
      {
        writer.WritePropertyName("reasonCode");
        writer.WriteStartArray();

        foreach (CodeableConcept valReasonCode in ReasonCode)
        {
          valReasonCode.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ReasonReference != null) && (ReasonReference.Count != 0))
      {
        writer.WritePropertyName("reasonReference");
        writer.WriteStartArray();

        foreach (Reference valReasonReference in ReasonReference)
        {
          valReasonReference.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Note != null) && (Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();

        foreach (Annotation valNote in Note)
        {
          valNote.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((EvaluationMessage != null) && (EvaluationMessage.Count != 0))
      {
        writer.WritePropertyName("evaluationMessage");
        writer.WriteStartArray();

        foreach (Reference valEvaluationMessage in EvaluationMessage)
        {
          valEvaluationMessage.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (OutputParameters != null)
      {
        writer.WritePropertyName("outputParameters");
        OutputParameters.SerializeJson(ref writer, options);
      }

      if (Result != null)
      {
        writer.WritePropertyName("result");
        Result.SerializeJson(ref writer, options);
      }

      if ((DataRequirement != null) && (DataRequirement.Count != 0))
      {
        writer.WritePropertyName("dataRequirement");
        writer.WriteStartArray();

        foreach (DataRequirement valDataRequirement in DataRequirement)
        {
          valDataRequirement.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "dataRequirement":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DataRequirement = new List<DataRequirement>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.DataRequirement objDataRequirement = new Fhir.R4.Models.DataRequirement();
            objDataRequirement.DeserializeJson(ref reader, options);
            DataRequirement.Add(objDataRequirement);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DataRequirement.Count == 0)
          {
            DataRequirement = null;
          }

          break;

        case "encounter":
          Encounter = new Fhir.R4.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
          break;

        case "evaluationMessage":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          EvaluationMessage = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objEvaluationMessage = new Fhir.R4.Models.Reference();
            objEvaluationMessage.DeserializeJson(ref reader, options);
            EvaluationMessage.Add(objEvaluationMessage);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (EvaluationMessage.Count == 0)
          {
            EvaluationMessage = null;
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

        case "moduleUri":
          ModuleUri = reader.GetString();
          break;

        case "_moduleUri":
          _ModuleUri = new Fhir.R4.Models.Element();
          _ModuleUri.DeserializeJson(ref reader, options);
          break;

        case "moduleCanonical":
          ModuleCanonical = reader.GetString();
          break;

        case "_moduleCanonical":
          _ModuleCanonical = new Fhir.R4.Models.Element();
          _ModuleCanonical.DeserializeJson(ref reader, options);
          break;

        case "moduleCodeableConcept":
          ModuleCodeableConcept = new Fhir.R4.Models.CodeableConcept();
          ModuleCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Annotation objNote = new Fhir.R4.Models.Annotation();
            objNote.DeserializeJson(ref reader, options);
            Note.Add(objNote);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Note.Count == 0)
          {
            Note = null;
          }

          break;

        case "occurrenceDateTime":
          OccurrenceDateTime = reader.GetString();
          break;

        case "_occurrenceDateTime":
          _OccurrenceDateTime = new Fhir.R4.Models.Element();
          _OccurrenceDateTime.DeserializeJson(ref reader, options);
          break;

        case "outputParameters":
          OutputParameters = new Fhir.R4.Models.Reference();
          OutputParameters.DeserializeJson(ref reader, options);
          break;

        case "performer":
          Performer = new Fhir.R4.Models.Reference();
          Performer.DeserializeJson(ref reader, options);
          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objReasonCode = new Fhir.R4.Models.CodeableConcept();
            objReasonCode.DeserializeJson(ref reader, options);
            ReasonCode.Add(objReasonCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReasonCode.Count == 0)
          {
            ReasonCode = null;
          }

          break;

        case "reasonReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonReference = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objReasonReference = new Fhir.R4.Models.Reference();
            objReasonReference.DeserializeJson(ref reader, options);
            ReasonReference.Add(objReasonReference);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReasonReference.Count == 0)
          {
            ReasonReference = null;
          }

          break;

        case "requestIdentifier":
          RequestIdentifier = new Fhir.R4.Models.Identifier();
          RequestIdentifier.DeserializeJson(ref reader, options);
          break;

        case "result":
          Result = new Fhir.R4.Models.Reference();
          Result.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new Fhir.R4.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
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
