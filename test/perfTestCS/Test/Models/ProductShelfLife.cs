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
  /// The shelf-life and storage information for a medicinal product item or container can be described using this class.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<ProductShelfLife>))]
  public class ProductShelfLife : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Unique identifier for the packaged Medicinal Product.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// The shelf life time period can be specified using a numerical value for the period of time and its unit of time measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used.
    /// </summary>
    public Quantity Period { get; set; }
    /// <summary>
    /// Special precautions for storage, if any, can be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified.
    /// </summary>
    public List<CodeableConcept> SpecialPrecautionsForStorage { get; set; }
    /// <summary>
    /// This describes the shelf life, taking into account various scenarios such as shelf life of the packaged Medicinal Product itself, shelf life after transformation where necessary and shelf life after the first opening of a bottle, etc. The shelf life type shall be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(ref Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(ref writer, options, false);

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(ref writer, options);
      }

      writer.WritePropertyName("type");
      Type.SerializeJson(ref writer, options);

      writer.WritePropertyName("period");
      Period.SerializeJson(ref writer, options);

      if ((SpecialPrecautionsForStorage != null) && (SpecialPrecautionsForStorage.Count != 0))
      {
        writer.WritePropertyName("specialPrecautionsForStorage");
        writer.WriteStartArray();

        foreach (CodeableConcept valSpecialPrecautionsForStorage in SpecialPrecautionsForStorage)
        {
          valSpecialPrecautionsForStorage.SerializeJson(ref writer, options, true);
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
        case "identifier":
          Identifier = new Fhir.R4.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "period":
          Period = new Fhir.R4.Models.Quantity();
          Period.DeserializeJson(ref reader, options);
          break;

        case "specialPrecautionsForStorage":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SpecialPrecautionsForStorage = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objSpecialPrecautionsForStorage = new Fhir.R4.Models.CodeableConcept();
            objSpecialPrecautionsForStorage.DeserializeJson(ref reader, options);
            SpecialPrecautionsForStorage.Add(objSpecialPrecautionsForStorage);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SpecialPrecautionsForStorage.Count == 0)
          {
            SpecialPrecautionsForStorage = null;
          }

          break;

        case "type":
          Type = new Fhir.R4.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
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
}
