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
  /// Strength expressed in terms of a reference substance.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<MedicinalProductIngredientSpecifiedSubstanceStrengthReferenceStrength>))]
  public class MedicinalProductIngredientSpecifiedSubstanceStrengthReferenceStrength : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The country or countries for which the strength range applies.
    /// </summary>
    public List<CodeableConcept> Country { get; set; }
    /// <summary>
    /// For when strength is measured at a particular point or distance.
    /// </summary>
    public string MeasurementPoint { get; set; }
    /// <summary>
    /// Extension container element for MeasurementPoint
    /// </summary>
    public Element _MeasurementPoint { get; set; }
    /// <summary>
    /// Strength expressed in terms of a reference substance.
    /// </summary>
    public Ratio Strength { get; set; }
    /// <summary>
    /// Strength expressed in terms of a reference substance.
    /// </summary>
    public Ratio StrengthLowLimit { get; set; }
    /// <summary>
    /// Relevant reference substance.
    /// </summary>
    public CodeableConcept Substance { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "country":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Country = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objCountry = new Fhir.R4.Models.CodeableConcept();
            objCountry.DeserializeJson(ref reader, options);
            Country.Add(objCountry);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Country.Count == 0)
          {
            Country = null;
          }

          break;

        case "measurementPoint":
          MeasurementPoint = reader.GetString();
          break;

        case "_measurementPoint":
          _MeasurementPoint = new Fhir.R4.Models.Element();
          _MeasurementPoint.DeserializeJson(ref reader, options);
          break;

        case "strength":
          Strength = new Fhir.R4.Models.Ratio();
          Strength.DeserializeJson(ref reader, options);
          break;

        case "strengthLowLimit":
          StrengthLowLimit = new Fhir.R4.Models.Ratio();
          StrengthLowLimit.DeserializeJson(ref reader, options);
          break;

        case "substance":
          Substance = new Fhir.R4.Models.CodeableConcept();
          Substance.DeserializeJson(ref reader, options);
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
  /// <summary>
  /// Quantity of the substance or specified substance present in the manufactured item or pharmaceutical product.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<MedicinalProductIngredientSpecifiedSubstanceStrength>))]
  public class MedicinalProductIngredientSpecifiedSubstanceStrength : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The strength per unitary volume (or mass).
    /// </summary>
    public Ratio Concentration { get; set; }
    /// <summary>
    /// A lower limit for the strength per unitary volume (or mass), for when there is a range. The concentration attribute then becomes the upper limit.
    /// </summary>
    public Ratio ConcentrationLowLimit { get; set; }
    /// <summary>
    /// The country or countries for which the strength range applies.
    /// </summary>
    public List<CodeableConcept> Country { get; set; }
    /// <summary>
    /// For when strength is measured at a particular point or distance.
    /// </summary>
    public string MeasurementPoint { get; set; }
    /// <summary>
    /// Extension container element for MeasurementPoint
    /// </summary>
    public Element _MeasurementPoint { get; set; }
    /// <summary>
    /// The quantity of substance in the unit of presentation, or in the volume (or mass) of the single pharmaceutical product or manufactured item.
    /// </summary>
    public Ratio Presentation { get; set; }
    /// <summary>
    /// A lower limit for the quantity of substance in the unit of presentation. For use when there is a range of strengths, this is the lower limit, with the presentation attribute becoming the upper limit.
    /// </summary>
    public Ratio PresentationLowLimit { get; set; }
    /// <summary>
    /// Strength expressed in terms of a reference substance.
    /// </summary>
    public List<MedicinalProductIngredientSpecifiedSubstanceStrengthReferenceStrength> ReferenceStrength { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "concentration":
          Concentration = new Fhir.R4.Models.Ratio();
          Concentration.DeserializeJson(ref reader, options);
          break;

        case "concentrationLowLimit":
          ConcentrationLowLimit = new Fhir.R4.Models.Ratio();
          ConcentrationLowLimit.DeserializeJson(ref reader, options);
          break;

        case "country":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Country = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objCountry = new Fhir.R4.Models.CodeableConcept();
            objCountry.DeserializeJson(ref reader, options);
            Country.Add(objCountry);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Country.Count == 0)
          {
            Country = null;
          }

          break;

        case "measurementPoint":
          MeasurementPoint = reader.GetString();
          break;

        case "_measurementPoint":
          _MeasurementPoint = new Fhir.R4.Models.Element();
          _MeasurementPoint.DeserializeJson(ref reader, options);
          break;

        case "presentation":
          Presentation = new Fhir.R4.Models.Ratio();
          Presentation.DeserializeJson(ref reader, options);
          break;

        case "presentationLowLimit":
          PresentationLowLimit = new Fhir.R4.Models.Ratio();
          PresentationLowLimit.DeserializeJson(ref reader, options);
          break;

        case "referenceStrength":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReferenceStrength = new List<MedicinalProductIngredientSpecifiedSubstanceStrengthReferenceStrength>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.MedicinalProductIngredientSpecifiedSubstanceStrengthReferenceStrength objReferenceStrength = new Fhir.R4.Models.MedicinalProductIngredientSpecifiedSubstanceStrengthReferenceStrength();
            objReferenceStrength.DeserializeJson(ref reader, options);
            ReferenceStrength.Add(objReferenceStrength);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReferenceStrength.Count == 0)
          {
            ReferenceStrength = null;
          }

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
  /// <summary>
  /// A specified substance that comprises this ingredient.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<MedicinalProductIngredientSpecifiedSubstance>))]
  public class MedicinalProductIngredientSpecifiedSubstance : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The specified substance.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// Confidentiality level of the specified substance as the ingredient.
    /// </summary>
    public CodeableConcept Confidentiality { get; set; }
    /// <summary>
    /// The group of specified substance, e.g. group 1 to 4.
    /// </summary>
    public CodeableConcept Group { get; set; }
    /// <summary>
    /// Quantity of the substance or specified substance present in the manufactured item or pharmaceutical product.
    /// </summary>
    public List<MedicinalProductIngredientSpecifiedSubstanceStrength> Strength { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          Code = new Fhir.R4.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "confidentiality":
          Confidentiality = new Fhir.R4.Models.CodeableConcept();
          Confidentiality.DeserializeJson(ref reader, options);
          break;

        case "group":
          Group = new Fhir.R4.Models.CodeableConcept();
          Group.DeserializeJson(ref reader, options);
          break;

        case "strength":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Strength = new List<MedicinalProductIngredientSpecifiedSubstanceStrength>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.MedicinalProductIngredientSpecifiedSubstanceStrength objStrength = new Fhir.R4.Models.MedicinalProductIngredientSpecifiedSubstanceStrength();
            objStrength.DeserializeJson(ref reader, options);
            Strength.Add(objStrength);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Strength.Count == 0)
          {
            Strength = null;
          }

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
  /// <summary>
  /// The ingredient substance.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<MedicinalProductIngredientSubstance>))]
  public class MedicinalProductIngredientSubstance : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The ingredient substance.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// Quantity of the substance or specified substance present in the manufactured item or pharmaceutical product.
    /// </summary>
    public List<MedicinalProductIngredientSpecifiedSubstanceStrength> Strength { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          Code = new Fhir.R4.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "strength":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Strength = new List<MedicinalProductIngredientSpecifiedSubstanceStrength>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.MedicinalProductIngredientSpecifiedSubstanceStrength objStrength = new Fhir.R4.Models.MedicinalProductIngredientSpecifiedSubstanceStrength();
            objStrength.DeserializeJson(ref reader, options);
            Strength.Add(objStrength);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Strength.Count == 0)
          {
            Strength = null;
          }

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
  /// <summary>
  /// An ingredient of a manufactured item or pharmaceutical product.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonResourceConverter))]
  public class MedicinalProductIngredient : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "MedicinalProductIngredient";
    /// <summary>
    /// If the ingredient is a known or suspected allergen.
    /// </summary>
    public bool? AllergenicIndicator { get; set; }
    /// <summary>
    /// The identifier(s) of this Ingredient that are assigned by business processes and/or used to refer to it when a direct URL reference to the resource itself is not appropriate.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// Manufacturer of this Ingredient.
    /// </summary>
    public List<Reference> Manufacturer { get; set; }
    /// <summary>
    /// Ingredient role e.g. Active ingredient, excipient.
    /// </summary>
    public CodeableConcept Role { get; set; }
    /// <summary>
    /// A specified substance that comprises this ingredient.
    /// </summary>
    public List<MedicinalProductIngredientSpecifiedSubstance> SpecifiedSubstance { get; set; }
    /// <summary>
    /// The ingredient substance.
    /// </summary>
    public MedicinalProductIngredientSubstance Substance { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "allergenicIndicator":
          AllergenicIndicator = reader.GetBoolean();
          break;

        case "identifier":
          Identifier = new Fhir.R4.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "manufacturer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Manufacturer = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objManufacturer = new Fhir.R4.Models.Reference();
            objManufacturer.DeserializeJson(ref reader, options);
            Manufacturer.Add(objManufacturer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Manufacturer.Count == 0)
          {
            Manufacturer = null;
          }

          break;

        case "role":
          Role = new Fhir.R4.Models.CodeableConcept();
          Role.DeserializeJson(ref reader, options);
          break;

        case "specifiedSubstance":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SpecifiedSubstance = new List<MedicinalProductIngredientSpecifiedSubstance>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.MedicinalProductIngredientSpecifiedSubstance objSpecifiedSubstance = new Fhir.R4.Models.MedicinalProductIngredientSpecifiedSubstance();
            objSpecifiedSubstance.DeserializeJson(ref reader, options);
            SpecifiedSubstance.Add(objSpecifiedSubstance);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SpecifiedSubstance.Count == 0)
          {
            SpecifiedSubstance = null;
          }

          break;

        case "substance":
          Substance = new Fhir.R4.Models.MedicinalProductIngredientSubstance();
          Substance.DeserializeJson(ref reader, options);
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
