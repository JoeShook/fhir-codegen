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
  /// The technical details of an endpoint that can be used for electronic services, such as for web services providing XDS.b or a REST endpoint for another FHIR server. This may include any security context information.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<Endpoint>))]
  public class Endpoint : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "Endpoint";
    /// <summary>
    /// For rest-hook, and websocket, the end-point must be an http: or https: URL; for email, a mailto: url, for sms, a tel: url, and for message the endpoint can be in any form of url the server understands (usually, http: or mllp:). The URI is allowed to be relative; in which case, it is relative to the server end-point (since there may be more than one, clients should avoid using relative URIs)
    /// This address will be to the service base, without any parameters, or sub-services or resources tacked on.
    /// E.g. for a WADO-RS endpoint, the url should be "https://pacs.hospital.org/wado-rs"
    /// and not "https://pacs.hospital.org/wado-rs/studies/1.2.250.1.59.40211.12345678.678910/series/1.2.250.1.59.40211.789001276.14556172.67789/instances/...".
    /// </summary>
    public string Address { get; set; }
    /// <summary>
    /// Extension container element for Address
    /// </summary>
    public Element _Address { get; set; }
    /// <summary>
    /// For additional connectivity details for the protocol, extensions will be used at this point, as in the XDS example.
    /// </summary>
    public Coding ConnectionType { get; set; }
    /// <summary>
    /// Contact details for a human to contact about the subscription. The primary use of this for system administrator troubleshooting.
    /// </summary>
    public List<ContactPoint> Contact { get; set; }
    /// <summary>
    /// Exactly what these mean depends on the channel type. The can convey additional information to the recipient and/or meet security requirements.
    /// </summary>
    public List<string> Header { get; set; }
    /// <summary>
    /// Extension container element for Header
    /// </summary>
    public List<Element> _Header { get; set; }
    /// <summary>
    /// Identifier for the organization that is used to identify the endpoint across multiple disparate systems.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// This property is not typically used when searching for Endpoint resources for usage. The typical usage is via the reference from an applicable Organization/Location/Practitioner resource, which is where the context is provided. Multiple Locations may reference a single endpoint, and don't have to be within the same organization resource, but most likely within the same organizational hierarchy.
    /// </summary>
    public Reference ManagingOrganization { get; set; }
    /// <summary>
    /// A friendly name that this endpoint can be referred to with.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// Sending the payload has obvious security consequences. The server is responsible for ensuring that the content is appropriately secured.
    /// </summary>
    public List<string> PayloadMimeType { get; set; }
    /// <summary>
    /// Extension container element for PayloadMimeType
    /// </summary>
    public List<Element> _PayloadMimeType { get; set; }
    /// <summary>
    /// The payloadFormat describes the serialization format of the data, where the payloadType indicates the specific document/schema that is being transferred; e.g. DischargeSummary or CarePlan.
    /// </summary>
    public List<CodeableConcept> PayloadType { get; set; }
    /// <summary>
    /// The interval during which the endpoint is expected to be operational.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the endpoint as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
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

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(ref writer, options);
      }

      writer.WritePropertyName("connectionType");
      ConnectionType.SerializeJson(ref writer, options);

      if (!string.IsNullOrEmpty(Name))
      {
        writer.WriteString("name", (string)Name!);
      }

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(ref writer, options);
      }

      if (ManagingOrganization != null)
      {
        writer.WritePropertyName("managingOrganization");
        ManagingOrganization.SerializeJson(ref writer, options);
      }

      if ((Contact != null) && (Contact.Count != 0))
      {
        writer.WritePropertyName("contact");
        writer.WriteStartArray();

        foreach (ContactPoint valContact in Contact)
        {
          valContact.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(ref writer, options);
      }

      if ((PayloadType != null) && (PayloadType.Count != 0))
      {
        writer.WritePropertyName("payloadType");
        writer.WriteStartArray();

        foreach (CodeableConcept valPayloadType in PayloadType)
        {
          valPayloadType.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((PayloadMimeType != null) && (PayloadMimeType.Count != 0))
      {
        writer.WritePropertyName("payloadMimeType");
        writer.WriteStartArray();

        foreach (string valPayloadMimeType in PayloadMimeType)
        {
          writer.WriteStringValue(valPayloadMimeType);
        }

        writer.WriteEndArray();
      }

      if ((_PayloadMimeType != null) && (_PayloadMimeType.Count != 0))
      {
        writer.WritePropertyName("_payloadMimeType");
        writer.WriteStartArray();

        foreach (Element val_PayloadMimeType in _PayloadMimeType)
        {
          val_PayloadMimeType.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Address))
      {
        writer.WriteString("address", (string)Address!);
      }

      if (_Address != null)
      {
        writer.WritePropertyName("_address");
        _Address.SerializeJson(ref writer, options);
      }

      if ((Header != null) && (Header.Count != 0))
      {
        writer.WritePropertyName("header");
        writer.WriteStartArray();

        foreach (string valHeader in Header)
        {
          writer.WriteStringValue(valHeader);
        }

        writer.WriteEndArray();
      }

      if ((_Header != null) && (_Header.Count != 0))
      {
        writer.WritePropertyName("_header");
        writer.WriteStartArray();

        foreach (Element val_Header in _Header)
        {
          val_Header.SerializeJson(ref writer, options, true);
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
        case "address":
          Address = reader.GetString();
          break;

        case "_address":
          _Address = new Fhir.R4.Models.Element();
          _Address.DeserializeJson(ref reader, options);
          break;

        case "connectionType":
          ConnectionType = new Fhir.R4.Models.Coding();
          ConnectionType.DeserializeJson(ref reader, options);
          break;

        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Contact = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.ContactPoint objContact = new Fhir.R4.Models.ContactPoint();
            objContact.DeserializeJson(ref reader, options);
            Contact.Add(objContact);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Contact.Count == 0)
          {
            Contact = null;
          }

          break;

        case "header":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Header = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Header.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Header.Count == 0)
          {
            Header = null;
          }

          break;

        case "_header":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Header = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Element obj_Header = new Fhir.R4.Models.Element();
            obj_Header.DeserializeJson(ref reader, options);
            _Header.Add(obj_Header);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Header.Count == 0)
          {
            _Header = null;
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

        case "managingOrganization":
          ManagingOrganization = new Fhir.R4.Models.Reference();
          ManagingOrganization.DeserializeJson(ref reader, options);
          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new Fhir.R4.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "payloadMimeType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PayloadMimeType = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            PayloadMimeType.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PayloadMimeType.Count == 0)
          {
            PayloadMimeType = null;
          }

          break;

        case "_payloadMimeType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _PayloadMimeType = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Element obj_PayloadMimeType = new Fhir.R4.Models.Element();
            obj_PayloadMimeType.DeserializeJson(ref reader, options);
            _PayloadMimeType.Add(obj_PayloadMimeType);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_PayloadMimeType.Count == 0)
          {
            _PayloadMimeType = null;
          }

          break;

        case "payloadType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PayloadType = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objPayloadType = new Fhir.R4.Models.CodeableConcept();
            objPayloadType.DeserializeJson(ref reader, options);
            PayloadType.Add(objPayloadType);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PayloadType.Count == 0)
          {
            PayloadType = null;
          }

          break;

        case "period":
          Period = new Fhir.R4.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
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
