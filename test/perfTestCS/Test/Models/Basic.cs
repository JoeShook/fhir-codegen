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
  /// Basic is used for handling concepts not yet defined in FHIR, narrative-only resources that don't map to an existing resource, and custom resources not appropriate for inclusion in the FHIR specification.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonResourceConverter))]
  public class Basic : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "Basic";
    /// <summary>
    /// Indicates who was responsible for creating the resource instance.
    /// </summary>
    public Reference Author { get; set; }
    /// <summary>
    /// Because resource references will only be able to indicate 'Basic', the type of reference will need to be specified in a Profile identified as part of the resource.  Refer to the resource notes section for information on appropriate terminologies for this code.
    /// This element is labeled as a modifier because it defines the meaning of the resource and cannot be ignored.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// Identifies when the resource was first created.
    /// </summary>
    public string Created { get; set; }
    /// <summary>
    /// Extension container element for Created
    /// </summary>
    public Element _Created { get; set; }
    /// <summary>
    /// Identifier assigned to the resource for business purposes, outside the context of FHIR.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Optional as not all potential resources will have subjects.  Resources associated with multiple subjects can handle this via extension.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "author":
          Author = new Fhir.R4.Models.Reference();
          Author.DeserializeJson(ref reader, options);
          break;

        case "code":
          Code = new Fhir.R4.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "created":
          Created = reader.GetString();
          break;

        case "_created":
          _Created = new Fhir.R4.Models.Element();
          _Created.DeserializeJson(ref reader, options);
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
