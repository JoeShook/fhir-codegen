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
  /// A  text note which also  contains information about who made the statement and when.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<Annotation>))]
  public class Annotation : Element,  IFhirJsonSerializable {
    /// <summary>
    /// Organization is used when there's no need for specific attribution as to who made the comment.
    /// </summary>
    public Reference AuthorReference { get; set; }
    /// <summary>
    /// Organization is used when there's no need for specific attribution as to who made the comment.
    /// </summary>
    public string AuthorString { get; set; }
    /// <summary>
    /// Extension container element for AuthorString
    /// </summary>
    public Element _AuthorString { get; set; }
    /// <summary>
    /// The text of the annotation in markdown format.
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Extension container element for Text
    /// </summary>
    public Element _Text { get; set; }
    /// <summary>
    /// Indicates when this particular annotation was made.
    /// </summary>
    public string Time { get; set; }
    /// <summary>
    /// Extension container element for Time
    /// </summary>
    public Element _Time { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(ref Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.Element)this).SerializeJson(ref writer, options, false);

      if (AuthorReference != null)
      {
        writer.WritePropertyName("authorReference");
        AuthorReference.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(AuthorString))
      {
        writer.WriteString("authorString", (string)AuthorString!);
      }

      if (_AuthorString != null)
      {
        writer.WritePropertyName("_authorString");
        _AuthorString.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Time))
      {
        writer.WriteString("time", (string)Time!);
      }

      if (_Time != null)
      {
        writer.WritePropertyName("_time");
        _Time.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Text))
      {
        writer.WriteString("text", (string)Text!);
      }

      if (_Text != null)
      {
        writer.WritePropertyName("_text");
        _Text.SerializeJson(ref writer, options);
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
        case "authorReference":
          AuthorReference = new Fhir.R4.Models.Reference();
          AuthorReference.DeserializeJson(ref reader, options);
          break;

        case "authorString":
          AuthorString = reader.GetString();
          break;

        case "_authorString":
          _AuthorString = new Fhir.R4.Models.Element();
          _AuthorString.DeserializeJson(ref reader, options);
          break;

        case "text":
          Text = reader.GetString();
          break;

        case "_text":
          _Text = new Fhir.R4.Models.Element();
          _Text.DeserializeJson(ref reader, options);
          break;

        case "time":
          Time = reader.GetString();
          break;

        case "_time":
          _Time = new Fhir.R4.Models.Element();
          _Time.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.Element)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
