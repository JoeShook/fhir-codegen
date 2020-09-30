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
  /// An address expressed using postal conventions (as opposed to GPS or other location definition formats).  This data type may be used to convey addresses for use in delivering mail as well as for visiting locations which might not be valid for mail delivery.  There are a variety of postal address formats defined around the world.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<Address>))]
  public class Address : Element,  IFhirJsonSerializable {
    /// <summary>
    /// The name of the city, town, suburb, village or other community or delivery center.
    /// </summary>
    public string City { get; set; }
    /// <summary>
    /// Extension container element for City
    /// </summary>
    public Element _City { get; set; }
    /// <summary>
    /// ISO 3166 3 letter codes can be used in place of a human readable country name.
    /// </summary>
    public string Country { get; set; }
    /// <summary>
    /// Extension container element for Country
    /// </summary>
    public Element _Country { get; set; }
    /// <summary>
    /// District is sometimes known as county, but in some regions 'county' is used in place of city (municipality), so county name should be conveyed in city instead.
    /// </summary>
    public string District { get; set; }
    /// <summary>
    /// Extension container element for District
    /// </summary>
    public Element _District { get; set; }
    /// <summary>
    /// This component contains the house number, apartment number, street name, street direction,  P.O. Box number, delivery hints, and similar address information.
    /// </summary>
    public List<string> Line { get; set; }
    /// <summary>
    /// Extension container element for Line
    /// </summary>
    public List<Element> _Line { get; set; }
    /// <summary>
    /// Time period when address was/is in use.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// A postal code designating a region defined by the postal service.
    /// </summary>
    public string PostalCode { get; set; }
    /// <summary>
    /// Extension container element for PostalCode
    /// </summary>
    public Element _PostalCode { get; set; }
    /// <summary>
    /// Sub-unit of a country with limited sovereignty in a federally organized country. A code may be used if codes are in common use (e.g. US 2 letter state codes).
    /// </summary>
    public string State { get; set; }
    /// <summary>
    /// Extension container element for State
    /// </summary>
    public Element _State { get; set; }
    /// <summary>
    /// Can provide both a text representation and parts. Applications updating an address SHALL ensure that  when both text and parts are present,  no content is included in the text that isn't found in a part.
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Extension container element for Text
    /// </summary>
    public Element _Text { get; set; }
    /// <summary>
    /// The definition of Address states that "address is intended to describe postal addresses, not physical locations". However, many applications track whether an address has a dual purpose of being a location that can be visited as well as being a valid delivery destination, and Postal addresses are often used as proxies for physical locations (also see the [Location](location.html#) resource).
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
    /// <summary>
    /// Applications can assume that an address is current unless it explicitly says that it is temporary or old.
    /// </summary>
    public string Use { get; set; }
    /// <summary>
    /// Extension container element for Use
    /// </summary>
    public Element _Use { get; set; }
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

      if (!string.IsNullOrEmpty(Use))
      {
        writer.WriteString("use", (string)Use!);
      }

      if (_Use != null)
      {
        writer.WritePropertyName("_use");
        _Use.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(ref writer, options);
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

      if ((Line != null) && (Line.Count != 0))
      {
        writer.WritePropertyName("line");
        writer.WriteStartArray();

        foreach (string valLine in Line)
        {
          writer.WriteStringValue(valLine);
        }

        writer.WriteEndArray();
      }

      if ((_Line != null) && (_Line.Count != 0))
      {
        writer.WritePropertyName("_line");
        writer.WriteStartArray();

        foreach (Element val_Line in _Line)
        {
          val_Line.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(City))
      {
        writer.WriteString("city", (string)City!);
      }

      if (_City != null)
      {
        writer.WritePropertyName("_city");
        _City.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(District))
      {
        writer.WriteString("district", (string)District!);
      }

      if (_District != null)
      {
        writer.WritePropertyName("_district");
        _District.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(State))
      {
        writer.WriteString("state", (string)State!);
      }

      if (_State != null)
      {
        writer.WritePropertyName("_state");
        _State.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(PostalCode))
      {
        writer.WriteString("postalCode", (string)PostalCode!);
      }

      if (_PostalCode != null)
      {
        writer.WritePropertyName("_postalCode");
        _PostalCode.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Country))
      {
        writer.WriteString("country", (string)Country!);
      }

      if (_Country != null)
      {
        writer.WritePropertyName("_country");
        _Country.SerializeJson(ref writer, options);
      }

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(ref writer, options);
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
        case "city":
          City = reader.GetString();
          break;

        case "_city":
          _City = new Fhir.R4.Models.Element();
          _City.DeserializeJson(ref reader, options);
          break;

        case "country":
          Country = reader.GetString();
          break;

        case "_country":
          _Country = new Fhir.R4.Models.Element();
          _Country.DeserializeJson(ref reader, options);
          break;

        case "district":
          District = reader.GetString();
          break;

        case "_district":
          _District = new Fhir.R4.Models.Element();
          _District.DeserializeJson(ref reader, options);
          break;

        case "line":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Line = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Line.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Line.Count == 0)
          {
            Line = null;
          }

          break;

        case "_line":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Line = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Element obj_Line = new Fhir.R4.Models.Element();
            obj_Line.DeserializeJson(ref reader, options);
            _Line.Add(obj_Line);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Line.Count == 0)
          {
            _Line = null;
          }

          break;

        case "period":
          Period = new Fhir.R4.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "postalCode":
          PostalCode = reader.GetString();
          break;

        case "_postalCode":
          _PostalCode = new Fhir.R4.Models.Element();
          _PostalCode.DeserializeJson(ref reader, options);
          break;

        case "state":
          State = reader.GetString();
          break;

        case "_state":
          _State = new Fhir.R4.Models.Element();
          _State.DeserializeJson(ref reader, options);
          break;

        case "text":
          Text = reader.GetString();
          break;

        case "_text":
          _Text = new Fhir.R4.Models.Element();
          _Text.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new Fhir.R4.Models.Element();
          _Type.DeserializeJson(ref reader, options);
          break;

        case "use":
          Use = reader.GetString();
          break;

        case "_use":
          _Use = new Fhir.R4.Models.Element();
          _Use.DeserializeJson(ref reader, options);
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
