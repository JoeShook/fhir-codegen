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
  /// An amount of economic utility in some recognized currency.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<Money>))]
  public class Money : Element,  IFhirJsonSerializable {
    /// <summary>
    /// ISO 4217 Currency Code.
    /// </summary>
    public string Currency { get; set; }
    /// <summary>
    /// Extension container element for Currency
    /// </summary>
    public Element _Currency { get; set; }
    /// <summary>
    /// Monetary values have their own rules for handling precision (refer to standard accounting text books).
    /// </summary>
    public decimal? Value { get; set; }
    /// <summary>
    /// Extension container element for Value
    /// </summary>
    public Element _Value { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "currency":
          Currency = reader.GetString();
          break;

        case "_currency":
          _Currency = new Fhir.R4.Models.Element();
          _Currency.DeserializeJson(ref reader, options);
          break;

        case "value":
          Value = reader.GetDecimal();
          break;

        case "_value":
          _Value = new Fhir.R4.Models.Element();
          _Value.DeserializeJson(ref reader, options);
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
