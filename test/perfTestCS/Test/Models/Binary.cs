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
  /// A resource that represents the data of a single raw artifact as digital content accessible in its native format.  A Binary resource can contain any content, whether text, image, pdf, zip archive, etc.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonResourceConverter))]
  public class Binary : Resource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "Binary";
    /// <summary>
    /// MimeType of the binary content represented as a standard MimeType (BCP 13).
    /// </summary>
    public string ContentType { get; set; }
    /// <summary>
    /// Extension container element for ContentType
    /// </summary>
    public Element _ContentType { get; set; }
    /// <summary>
    /// If the content type is itself base64 encoding, then this will be base64 encoded twice - what is created by un-base64ing the content must be the specified content type.
    /// </summary>
    public string Data { get; set; }
    /// <summary>
    /// Extension container element for Data
    /// </summary>
    public Element _Data { get; set; }
    /// <summary>
    /// Very often, a server will also know of a resource that references the binary, and can automatically apply the appropriate access rules based on that reference. However, there are some circumstances where this is not appropriate, e.g. the binary is uploaded directly to the server without any linking resource, the binary is referred to from multiple different resources, and/or the binary is content such as an application logo that has less protection than any of the resources that reference it.
    /// </summary>
    public Reference SecurityContext { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "contentType":
          ContentType = reader.GetString();
          break;

        case "_contentType":
          _ContentType = new Fhir.R4.Models.Element();
          _ContentType.DeserializeJson(ref reader, options);
          break;

        case "data":
          Data = reader.GetString();
          break;

        case "_data":
          _Data = new Fhir.R4.Models.Element();
          _Data.DeserializeJson(ref reader, options);
          break;

        case "securityContext":
          SecurityContext = new Fhir.R4.Models.Reference();
          SecurityContext.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.Resource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
