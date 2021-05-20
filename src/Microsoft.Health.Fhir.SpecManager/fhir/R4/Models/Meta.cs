// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR4.Serialization;

namespace fhirCsR4.Models
{
  /// <summary>
  /// The metadata about a resource. This is content in the resource that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<Meta>))]
  public class Meta : Element,  IFhirJsonSerializable {
    /// <summary>
    /// This value is always populated except when the resource is first being created. The server / resource manager sets this value; what a client provides is irrelevant. This is equivalent to the HTTP Last-Modified and SHOULD have the same value on a [read](http.html#read) interaction.
    /// </summary>
    public string LastUpdated { get; set; }
    /// <summary>
    /// Extension container element for LastUpdated
    /// </summary>
    public Element _LastUpdated { get; set; }
    /// <summary>
    /// It is up to the server and/or other infrastructure of policy to determine whether/how these claims are verified and/or updated over time.  The list of profile URLs is a set.
    /// </summary>
    public List<string> Profile { get; set; }
    /// <summary>
    /// Extension container element for Profile
    /// </summary>
    public List<Element> _Profile { get; set; }
    /// <summary>
    /// The security labels can be updated without changing the stated version of the resource. The list of security labels is a set. Uniqueness is based the system/code, and version and display are ignored.
    /// </summary>
    public List<Coding> Security { get; set; }
    /// <summary>
    /// In the provenance resource, this corresponds to Provenance.entity.what[x]. The exact use of the source (and the implied Provenance.entity.role) is left to implementer discretion. Only one nominated source is allowed; for additional provenance details, a full Provenance resource should be used. 
    /// This element can be used to indicate where the current master source of a resource that has a canonical URL if the resource is no longer hosted at the canonical URL.
    /// </summary>
    public string Source { get; set; }
    /// <summary>
    /// Extension container element for Source
    /// </summary>
    public Element _Source { get; set; }
    /// <summary>
    /// The tags can be updated without changing the stated version of the resource. The list of tags is a set. Uniqueness is based the system/code, and version and display are ignored.
    /// </summary>
    public List<Coding> Tag { get; set; }
    /// <summary>
    /// The server assigns this value, and ignores what the client specifies, except in the case that the server is imposing version integrity on updates/deletes.
    /// </summary>
    public string VersionId { get; set; }
    /// <summary>
    /// Extension container element for VersionId
    /// </summary>
    public Element _VersionId { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4.Models.Element)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(VersionId))
      {
        writer.WriteString("versionId", (string)VersionId!);
      }

      if (_VersionId != null)
      {
        writer.WritePropertyName("_versionId");
        _VersionId.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(LastUpdated))
      {
        writer.WriteString("lastUpdated", (string)LastUpdated!);
      }

      if (_LastUpdated != null)
      {
        writer.WritePropertyName("_lastUpdated");
        _LastUpdated.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Source))
      {
        writer.WriteString("source", (string)Source!);
      }

      if (_Source != null)
      {
        writer.WritePropertyName("_source");
        _Source.SerializeJson(writer, options);
      }

      if ((Profile != null) && (Profile.Count != 0))
      {
        writer.WritePropertyName("profile");
        writer.WriteStartArray();

        foreach (string valProfile in Profile)
        {
          writer.WriteStringValue(valProfile);
        }

        writer.WriteEndArray();
      }

      if ((_Profile != null) && (_Profile.Count != 0))
      {
        writer.WritePropertyName("_profile");
        writer.WriteStartArray();

        foreach (Element val_Profile in _Profile)
        {
          val_Profile.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Security != null) && (Security.Count != 0))
      {
        writer.WritePropertyName("security");
        writer.WriteStartArray();

        foreach (Coding valSecurity in Security)
        {
          valSecurity.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Tag != null) && (Tag.Count != 0))
      {
        writer.WritePropertyName("tag");
        writer.WriteStartArray();

        foreach (Coding valTag in Tag)
        {
          valTag.SerializeJson(writer, options, true);
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
        case "lastUpdated":
          LastUpdated = reader.GetString();
          break;

        case "_lastUpdated":
          _LastUpdated = new fhirCsR4.Models.Element();
          _LastUpdated.DeserializeJson(ref reader, options);
          break;

        case "profile":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Profile = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Profile.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Profile.Count == 0)
          {
            Profile = null;
          }

          break;

        case "_profile":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Profile = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Element obj_Profile = new fhirCsR4.Models.Element();
            obj_Profile.DeserializeJson(ref reader, options);
            _Profile.Add(obj_Profile);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Profile.Count == 0)
          {
            _Profile = null;
          }

          break;

        case "security":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Security = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Coding objSecurity = new fhirCsR4.Models.Coding();
            objSecurity.DeserializeJson(ref reader, options);
            Security.Add(objSecurity);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Security.Count == 0)
          {
            Security = null;
          }

          break;

        case "source":
          Source = reader.GetString();
          break;

        case "_source":
          _Source = new fhirCsR4.Models.Element();
          _Source.DeserializeJson(ref reader, options);
          break;

        case "tag":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Tag = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Coding objTag = new fhirCsR4.Models.Coding();
            objTag.DeserializeJson(ref reader, options);
            Tag.Add(objTag);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Tag.Count == 0)
          {
            Tag = null;
          }

          break;

        case "versionId":
          VersionId = reader.GetString();
          break;

        case "_versionId":
          _VersionId = new fhirCsR4.Models.Element();
          _VersionId.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.Element)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
