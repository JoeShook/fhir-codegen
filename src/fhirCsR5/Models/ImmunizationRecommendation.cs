// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR5.Serialization;

namespace fhirCsR5.Models
{
  /// <summary>
  /// Vaccine date recommendations.  For example, earliest date to administer, latest date to administer, etc.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ImmunizationRecommendationRecommendationDateCriterion>))]
  public class ImmunizationRecommendationRecommendationDateCriterion : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Date classification of recommendation.  For example, earliest date to give, latest date to give, etc.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// The date whose meaning is specified by dateCriterion.code.
    /// </summary>
    public string Value { get; set; }
    /// <summary>
    /// Extension container element for Value
    /// </summary>
    public Element _Value { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Value))
      {
        writer.WriteString("value", (string)Value!);
      }

      if (_Value != null)
      {
        writer.WritePropertyName("_value");
        _Value.SerializeJson(writer, options);
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
        case "code":
          Code = new fhirCsR5.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "value":
          Value = reader.GetString();
          break;

        case "_value":
          _Value = new fhirCsR5.Models.Element();
          _Value.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// A given instance of the .recommendation backbone element should correspond to a single recommended administration.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ImmunizationRecommendationRecommendation>))]
  public class ImmunizationRecommendationRecommendation : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Vaccine(s) which should not be used to fulfill the recommendation.
    /// </summary>
    public List<CodeableConcept> ContraindicatedVaccineCode { get; set; }
    /// <summary>
    /// Vaccine date recommendations.  For example, earliest date to administer, latest date to administer, etc.
    /// </summary>
    public List<ImmunizationRecommendationRecommendationDateCriterion> DateCriterion { get; set; }
    /// <summary>
    /// Contains the description about the protocol under which the vaccine was administered.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// The use of an integer is preferred if known. A string should only be used in cases where an integer is not available (such as when documenting a recurring booster dose).
    /// </summary>
    public string DoseNumber { get; set; }
    /// <summary>
    /// Extension container element for DoseNumber
    /// </summary>
    public Element _DoseNumber { get; set; }
    /// <summary>
    /// The reason for the assigned forecast status.
    /// </summary>
    public List<CodeableConcept> ForecastReason { get; set; }
    /// <summary>
    /// Indicates the patient status with respect to the path to immunity for the target disease.
    /// </summary>
    public CodeableConcept ForecastStatus { get; set; }
    /// <summary>
    /// One possible path to achieve presumed immunity against a disease - within the context of an authority.
    /// </summary>
    public string Series { get; set; }
    /// <summary>
    /// Extension container element for Series
    /// </summary>
    public Element _Series { get; set; }
    /// <summary>
    /// The use of an integer is preferred if known.
    /// </summary>
    public string SeriesDoses { get; set; }
    /// <summary>
    /// Extension container element for SeriesDoses
    /// </summary>
    public Element _SeriesDoses { get; set; }
    /// <summary>
    /// Immunization event history and/or evaluation that supports the status and recommendation.
    /// </summary>
    public List<Reference> SupportingImmunization { get; set; }
    /// <summary>
    /// Patient Information that supports the status and recommendation.  This includes patient observations, adverse reactions and allergy/intolerance information.
    /// </summary>
    public List<Reference> SupportingPatientInformation { get; set; }
    /// <summary>
    /// A given instance of the .recommendation backbone element should correspond to a single recommended administration but sometimes that administration (eg. MMR) will encompass multiple diseases, thus the targetDisease element is allowed to repeat.
    /// </summary>
    public List<CodeableConcept> TargetDisease { get; set; }
    /// <summary>
    /// Vaccine(s) or vaccine group that pertain to the recommendation.
    /// </summary>
    public List<CodeableConcept> VaccineCode { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if ((VaccineCode != null) && (VaccineCode.Count != 0))
      {
        writer.WritePropertyName("vaccineCode");
        writer.WriteStartArray();

        foreach (CodeableConcept valVaccineCode in VaccineCode)
        {
          valVaccineCode.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((TargetDisease != null) && (TargetDisease.Count != 0))
      {
        writer.WritePropertyName("targetDisease");
        writer.WriteStartArray();

        foreach (CodeableConcept valTargetDisease in TargetDisease)
        {
          valTargetDisease.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ContraindicatedVaccineCode != null) && (ContraindicatedVaccineCode.Count != 0))
      {
        writer.WritePropertyName("contraindicatedVaccineCode");
        writer.WriteStartArray();

        foreach (CodeableConcept valContraindicatedVaccineCode in ContraindicatedVaccineCode)
        {
          valContraindicatedVaccineCode.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (ForecastStatus != null)
      {
        writer.WritePropertyName("forecastStatus");
        ForecastStatus.SerializeJson(writer, options);
      }

      if ((ForecastReason != null) && (ForecastReason.Count != 0))
      {
        writer.WritePropertyName("forecastReason");
        writer.WriteStartArray();

        foreach (CodeableConcept valForecastReason in ForecastReason)
        {
          valForecastReason.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((DateCriterion != null) && (DateCriterion.Count != 0))
      {
        writer.WritePropertyName("dateCriterion");
        writer.WriteStartArray();

        foreach (ImmunizationRecommendationRecommendationDateCriterion valDateCriterion in DateCriterion)
        {
          valDateCriterion.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Description))
      {
        writer.WriteString("description", (string)Description!);
      }

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Series))
      {
        writer.WriteString("series", (string)Series!);
      }

      if (_Series != null)
      {
        writer.WritePropertyName("_series");
        _Series.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(DoseNumber))
      {
        writer.WriteString("doseNumber", (string)DoseNumber!);
      }

      if (_DoseNumber != null)
      {
        writer.WritePropertyName("_doseNumber");
        _DoseNumber.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(SeriesDoses))
      {
        writer.WriteString("seriesDoses", (string)SeriesDoses!);
      }

      if (_SeriesDoses != null)
      {
        writer.WritePropertyName("_seriesDoses");
        _SeriesDoses.SerializeJson(writer, options);
      }

      if ((SupportingImmunization != null) && (SupportingImmunization.Count != 0))
      {
        writer.WritePropertyName("supportingImmunization");
        writer.WriteStartArray();

        foreach (Reference valSupportingImmunization in SupportingImmunization)
        {
          valSupportingImmunization.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((SupportingPatientInformation != null) && (SupportingPatientInformation.Count != 0))
      {
        writer.WritePropertyName("supportingPatientInformation");
        writer.WriteStartArray();

        foreach (Reference valSupportingPatientInformation in SupportingPatientInformation)
        {
          valSupportingPatientInformation.SerializeJson(writer, options, true);
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
        case "contraindicatedVaccineCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ContraindicatedVaccineCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objContraindicatedVaccineCode = new fhirCsR5.Models.CodeableConcept();
            objContraindicatedVaccineCode.DeserializeJson(ref reader, options);
            ContraindicatedVaccineCode.Add(objContraindicatedVaccineCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ContraindicatedVaccineCode.Count == 0)
          {
            ContraindicatedVaccineCode = null;
          }

          break;

        case "dateCriterion":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DateCriterion = new List<ImmunizationRecommendationRecommendationDateCriterion>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.ImmunizationRecommendationRecommendationDateCriterion objDateCriterion = new fhirCsR5.Models.ImmunizationRecommendationRecommendationDateCriterion();
            objDateCriterion.DeserializeJson(ref reader, options);
            DateCriterion.Add(objDateCriterion);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DateCriterion.Count == 0)
          {
            DateCriterion = null;
          }

          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new fhirCsR5.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "doseNumber":
          DoseNumber = reader.GetString();
          break;

        case "_doseNumber":
          _DoseNumber = new fhirCsR5.Models.Element();
          _DoseNumber.DeserializeJson(ref reader, options);
          break;

        case "forecastReason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ForecastReason = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objForecastReason = new fhirCsR5.Models.CodeableConcept();
            objForecastReason.DeserializeJson(ref reader, options);
            ForecastReason.Add(objForecastReason);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ForecastReason.Count == 0)
          {
            ForecastReason = null;
          }

          break;

        case "forecastStatus":
          ForecastStatus = new fhirCsR5.Models.CodeableConcept();
          ForecastStatus.DeserializeJson(ref reader, options);
          break;

        case "series":
          Series = reader.GetString();
          break;

        case "_series":
          _Series = new fhirCsR5.Models.Element();
          _Series.DeserializeJson(ref reader, options);
          break;

        case "seriesDoses":
          SeriesDoses = reader.GetString();
          break;

        case "_seriesDoses":
          _SeriesDoses = new fhirCsR5.Models.Element();
          _SeriesDoses.DeserializeJson(ref reader, options);
          break;

        case "supportingImmunization":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SupportingImmunization = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objSupportingImmunization = new fhirCsR5.Models.Reference();
            objSupportingImmunization.DeserializeJson(ref reader, options);
            SupportingImmunization.Add(objSupportingImmunization);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SupportingImmunization.Count == 0)
          {
            SupportingImmunization = null;
          }

          break;

        case "supportingPatientInformation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SupportingPatientInformation = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objSupportingPatientInformation = new fhirCsR5.Models.Reference();
            objSupportingPatientInformation.DeserializeJson(ref reader, options);
            SupportingPatientInformation.Add(objSupportingPatientInformation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SupportingPatientInformation.Count == 0)
          {
            SupportingPatientInformation = null;
          }

          break;

        case "targetDisease":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          TargetDisease = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objTargetDisease = new fhirCsR5.Models.CodeableConcept();
            objTargetDisease.DeserializeJson(ref reader, options);
            TargetDisease.Add(objTargetDisease);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (TargetDisease.Count == 0)
          {
            TargetDisease = null;
          }

          break;

        case "vaccineCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          VaccineCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objVaccineCode = new fhirCsR5.Models.CodeableConcept();
            objVaccineCode.DeserializeJson(ref reader, options);
            VaccineCode.Add(objVaccineCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (VaccineCode.Count == 0)
          {
            VaccineCode = null;
          }

          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// A patient's point-in-time set of recommendations (i.e. forecasting) according to a published schedule with optional supporting justification.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ImmunizationRecommendation>))]
  public class ImmunizationRecommendation : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "ImmunizationRecommendation";
    /// <summary>
    /// Indicates the authority who published the protocol (e.g. ACIP).
    /// </summary>
    public Reference Authority { get; set; }
    /// <summary>
    /// The date the immunization recommendation(s) were created.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// A unique identifier assigned to this particular recommendation record.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The URL pointing to a FHIR-defined protocol, guideline or other definition that is adhered to in whole or in part by this ImmunizationRecommendation.
    /// </summary>
    public List<string> InstantiatesCanonical { get; set; }
    /// <summary>
    /// Extension container element for InstantiatesCanonical
    /// </summary>
    public List<Element> _InstantiatesCanonical { get; set; }
    /// <summary>
    /// This might be an HTML page, PDF, etc. or could just be a non-resolvable URI identifier.
    /// </summary>
    public List<string> InstantiatesUri { get; set; }
    /// <summary>
    /// Extension container element for InstantiatesUri
    /// </summary>
    public List<Element> _InstantiatesUri { get; set; }
    /// <summary>
    /// The patient the recommendation(s) are for.
    /// </summary>
    public Reference Patient { get; set; }
    /// <summary>
    /// A given instance of the .recommendation backbone element should correspond to a single recommended administration.
    /// </summary>
    public List<ImmunizationRecommendationRecommendation> Recommendation { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR5.Models.DomainResource)this).SerializeJson(writer, options, false);

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((InstantiatesCanonical != null) && (InstantiatesCanonical.Count != 0))
      {
        writer.WritePropertyName("instantiatesCanonical");
        writer.WriteStartArray();

        foreach (string valInstantiatesCanonical in InstantiatesCanonical)
        {
          writer.WriteStringValue(valInstantiatesCanonical);
        }

        writer.WriteEndArray();
      }

      if ((_InstantiatesCanonical != null) && (_InstantiatesCanonical.Count != 0))
      {
        writer.WritePropertyName("_instantiatesCanonical");
        writer.WriteStartArray();

        foreach (Element val_InstantiatesCanonical in _InstantiatesCanonical)
        {
          val_InstantiatesCanonical.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((InstantiatesUri != null) && (InstantiatesUri.Count != 0))
      {
        writer.WritePropertyName("instantiatesUri");
        writer.WriteStartArray();

        foreach (string valInstantiatesUri in InstantiatesUri)
        {
          writer.WriteStringValue(valInstantiatesUri);
        }

        writer.WriteEndArray();
      }

      if ((_InstantiatesUri != null) && (_InstantiatesUri.Count != 0))
      {
        writer.WritePropertyName("_instantiatesUri");
        writer.WriteStartArray();

        foreach (Element val_InstantiatesUri in _InstantiatesUri)
        {
          val_InstantiatesUri.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Patient != null)
      {
        writer.WritePropertyName("patient");
        Patient.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Date))
      {
        writer.WriteString("date", (string)Date!);
      }

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(writer, options);
      }

      if (Authority != null)
      {
        writer.WritePropertyName("authority");
        Authority.SerializeJson(writer, options);
      }

      if ((Recommendation != null) && (Recommendation.Count != 0))
      {
        writer.WritePropertyName("recommendation");
        writer.WriteStartArray();

        foreach (ImmunizationRecommendationRecommendation valRecommendation in Recommendation)
        {
          valRecommendation.SerializeJson(writer, options, true);
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
        case "authority":
          Authority = new fhirCsR5.Models.Reference();
          Authority.DeserializeJson(ref reader, options);
          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR5.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Identifier objIdentifier = new fhirCsR5.Models.Identifier();
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

        case "instantiatesCanonical":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          InstantiatesCanonical = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            InstantiatesCanonical.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (InstantiatesCanonical.Count == 0)
          {
            InstantiatesCanonical = null;
          }

          break;

        case "_instantiatesCanonical":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _InstantiatesCanonical = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_InstantiatesCanonical = new fhirCsR5.Models.Element();
            obj_InstantiatesCanonical.DeserializeJson(ref reader, options);
            _InstantiatesCanonical.Add(obj_InstantiatesCanonical);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_InstantiatesCanonical.Count == 0)
          {
            _InstantiatesCanonical = null;
          }

          break;

        case "instantiatesUri":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          InstantiatesUri = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            InstantiatesUri.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (InstantiatesUri.Count == 0)
          {
            InstantiatesUri = null;
          }

          break;

        case "_instantiatesUri":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _InstantiatesUri = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_InstantiatesUri = new fhirCsR5.Models.Element();
            obj_InstantiatesUri.DeserializeJson(ref reader, options);
            _InstantiatesUri.Add(obj_InstantiatesUri);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_InstantiatesUri.Count == 0)
          {
            _InstantiatesUri = null;
          }

          break;

        case "patient":
          Patient = new fhirCsR5.Models.Reference();
          Patient.DeserializeJson(ref reader, options);
          break;

        case "recommendation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Recommendation = new List<ImmunizationRecommendationRecommendation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.ImmunizationRecommendationRecommendation objRecommendation = new fhirCsR5.Models.ImmunizationRecommendationRecommendation();
            objRecommendation.DeserializeJson(ref reader, options);
            Recommendation.Add(objRecommendation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Recommendation.Count == 0)
          {
            Recommendation = null;
          }

          break;

        default:
          ((fhirCsR5.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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