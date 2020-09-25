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
  /// A populatioof people with some set of grouping criteria.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<Population>))]
  public class Population : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The age of the specific population.
    /// </summary>
    public Range AgeRange { get; set; }
    /// <summary>
    /// The age of the specific population.
    /// </summary>
    public CodeableConcept AgeCodeableConcept { get; set; }
    /// <summary>
    /// The gender of the specific population.
    /// </summary>
    public CodeableConcept Gender { get; set; }
    /// <summary>
    /// The existing physiological conditions of the specific population to which this applies.
    /// </summary>
    public CodeableConcept PhysiologicalCondition { get; set; }
    /// <summary>
    /// Race of the specific population.
    /// </summary>
    public CodeableConcept Race { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "ageRange":
          AgeRange = new Fhir.R4.Models.Range();
          AgeRange.DeserializeJson(ref reader, options);
          break;

        case "ageCodeableConcept":
          AgeCodeableConcept = new Fhir.R4.Models.CodeableConcept();
          AgeCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "gender":
          Gender = new Fhir.R4.Models.CodeableConcept();
          Gender.DeserializeJson(ref reader, options);
          break;

        case "physiologicalCondition":
          PhysiologicalCondition = new Fhir.R4.Models.CodeableConcept();
          PhysiologicalCondition.DeserializeJson(ref reader, options);
          break;

        case "race":
          Race = new Fhir.R4.Models.CodeableConcept();
          Race.DeserializeJson(ref reader, options);
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
