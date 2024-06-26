// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR2.Serialization;

namespace fhirCsR2.Models
{
  /// <summary>
  /// Describes the expected outcome for the subject.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<RiskAssessmentPrediction>))]
  public class RiskAssessmentPrediction : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// One of the potential outcomes for the patient (e.g. remission, death,  a particular condition).
    /// </summary>
    public CodeableConcept Outcome { get; set; }
    /// <summary>
    /// How likely is the outcome (in the specified timeframe).
    /// </summary>
    public decimal? ProbabilityDecimal { get; set; }
    /// <summary>
    /// Extension container element for ProbabilityDecimal
    /// </summary>
    public Element _ProbabilityDecimal { get; set; }
    /// <summary>
    /// How likely is the outcome (in the specified timeframe).
    /// </summary>
    public Range ProbabilityRange { get; set; }
    /// <summary>
    /// How likely is the outcome (in the specified timeframe).
    /// </summary>
    public CodeableConcept ProbabilityCodeableConcept { get; set; }
    /// <summary>
    /// Additional information explaining the basis for the prediction.
    /// </summary>
    public string Rationale { get; set; }
    /// <summary>
    /// Extension container element for Rationale
    /// </summary>
    public Element _Rationale { get; set; }
    /// <summary>
    /// Absolute risk is less meaningful than relative risk.
    /// </summary>
    public decimal? RelativeRisk { get; set; }
    /// <summary>
    /// Extension container element for RelativeRisk
    /// </summary>
    public Element _RelativeRisk { get; set; }
    /// <summary>
    /// Indicates the period of time or age range of the subject to which the specified probability applies.
    /// </summary>
    public Period WhenPeriod { get; set; }
    /// <summary>
    /// Indicates the period of time or age range of the subject to which the specified probability applies.
    /// </summary>
    public Range WhenRange { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR2.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Outcome != null)
      {
        writer.WritePropertyName("outcome");
        Outcome.SerializeJson(writer, options);
      }

      if (ProbabilityDecimal != null)
      {
        writer.WriteNumber("probabilityDecimal", (decimal)ProbabilityDecimal!);
      }

      if (_ProbabilityDecimal != null)
      {
        writer.WritePropertyName("_probabilityDecimal");
        _ProbabilityDecimal.SerializeJson(writer, options);
      }

      if (ProbabilityRange != null)
      {
        writer.WritePropertyName("probabilityRange");
        ProbabilityRange.SerializeJson(writer, options);
      }

      if (ProbabilityCodeableConcept != null)
      {
        writer.WritePropertyName("probabilityCodeableConcept");
        ProbabilityCodeableConcept.SerializeJson(writer, options);
      }

      if (RelativeRisk != null)
      {
        writer.WriteNumber("relativeRisk", (decimal)RelativeRisk!);
      }

      if (_RelativeRisk != null)
      {
        writer.WritePropertyName("_relativeRisk");
        _RelativeRisk.SerializeJson(writer, options);
      }

      if (WhenPeriod != null)
      {
        writer.WritePropertyName("whenPeriod");
        WhenPeriod.SerializeJson(writer, options);
      }

      if (WhenRange != null)
      {
        writer.WritePropertyName("whenRange");
        WhenRange.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Rationale))
      {
        writer.WriteString("rationale", (string)Rationale!);
      }

      if (_Rationale != null)
      {
        writer.WritePropertyName("_rationale");
        _Rationale.SerializeJson(writer, options);
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
        case "outcome":
          Outcome = new fhirCsR2.Models.CodeableConcept();
          Outcome.DeserializeJson(ref reader, options);
          break;

        case "probabilityDecimal":
          ProbabilityDecimal = reader.GetDecimal();
          break;

        case "_probabilityDecimal":
          _ProbabilityDecimal = new fhirCsR2.Models.Element();
          _ProbabilityDecimal.DeserializeJson(ref reader, options);
          break;

        case "probabilityRange":
          ProbabilityRange = new fhirCsR2.Models.Range();
          ProbabilityRange.DeserializeJson(ref reader, options);
          break;

        case "probabilityCodeableConcept":
          ProbabilityCodeableConcept = new fhirCsR2.Models.CodeableConcept();
          ProbabilityCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "rationale":
          Rationale = reader.GetString();
          break;

        case "_rationale":
          _Rationale = new fhirCsR2.Models.Element();
          _Rationale.DeserializeJson(ref reader, options);
          break;

        case "relativeRisk":
          RelativeRisk = reader.GetDecimal();
          break;

        case "_relativeRisk":
          _RelativeRisk = new fhirCsR2.Models.Element();
          _RelativeRisk.DeserializeJson(ref reader, options);
          break;

        case "whenPeriod":
          WhenPeriod = new fhirCsR2.Models.Period();
          WhenPeriod.DeserializeJson(ref reader, options);
          break;

        case "whenRange":
          WhenRange = new fhirCsR2.Models.Range();
          WhenRange.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// An assessment of the likely outcome(s) for a patient or other subject as well as the likelihood of each outcome.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<RiskAssessment>))]
  public class RiskAssessment : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "RiskAssessment";
    /// <summary>
    /// Indicates the source data considered as part of the assessment (FamilyHistory, Observations, Procedures, Conditions, etc.).
    /// </summary>
    public List<Reference> Basis { get; set; }
    /// <summary>
    /// For assessments or prognosis specific to a particular condition, indicates the condition being assessed.
    /// </summary>
    public Reference Condition { get; set; }
    /// <summary>
    /// The assessment results lose validity the more time elapses from when they are first made.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// The encounter where the assessment was performed.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// Business identifier assigned to the risk assessment.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// The method can influence the results of the assessment.
    /// </summary>
    public CodeableConcept Method { get; set; }
    /// <summary>
    /// One of the main reasons for assessing risks is to identify whether interventional steps are needed to reduce risk.
    /// </summary>
    public string Mitigation { get; set; }
    /// <summary>
    /// Extension container element for Mitigation
    /// </summary>
    public Element _Mitigation { get; set; }
    /// <summary>
    /// The provider or software application that performed the assessment.
    /// </summary>
    public Reference Performer { get; set; }
    /// <summary>
    /// Describes the expected outcome for the subject.
    /// </summary>
    public List<RiskAssessmentPrediction> Prediction { get; set; }
    /// <summary>
    /// The patient or group the risk assessment applies to.
    /// </summary>
    public Reference Subject { get; set; }
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


      ((fhirCsR2.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
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

      if (Condition != null)
      {
        writer.WritePropertyName("condition");
        Condition.SerializeJson(writer, options);
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(writer, options);
      }

      if (Performer != null)
      {
        writer.WritePropertyName("performer");
        Performer.SerializeJson(writer, options);
      }

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(writer, options);
      }

      if (Method != null)
      {
        writer.WritePropertyName("method");
        Method.SerializeJson(writer, options);
      }

      if ((Basis != null) && (Basis.Count != 0))
      {
        writer.WritePropertyName("basis");
        writer.WriteStartArray();

        foreach (Reference valBasis in Basis)
        {
          valBasis.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Prediction != null) && (Prediction.Count != 0))
      {
        writer.WritePropertyName("prediction");
        writer.WriteStartArray();

        foreach (RiskAssessmentPrediction valPrediction in Prediction)
        {
          valPrediction.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Mitigation))
      {
        writer.WriteString("mitigation", (string)Mitigation!);
      }

      if (_Mitigation != null)
      {
        writer.WritePropertyName("_mitigation");
        _Mitigation.SerializeJson(writer, options);
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
        case "basis":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Basis = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Reference objBasis = new fhirCsR2.Models.Reference();
            objBasis.DeserializeJson(ref reader, options);
            Basis.Add(objBasis);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Basis.Count == 0)
          {
            Basis = null;
          }

          break;

        case "condition":
          Condition = new fhirCsR2.Models.Reference();
          Condition.DeserializeJson(ref reader, options);
          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR2.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          Encounter = new fhirCsR2.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          Identifier = new fhirCsR2.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "method":
          Method = new fhirCsR2.Models.CodeableConcept();
          Method.DeserializeJson(ref reader, options);
          break;

        case "mitigation":
          Mitigation = reader.GetString();
          break;

        case "_mitigation":
          _Mitigation = new fhirCsR2.Models.Element();
          _Mitigation.DeserializeJson(ref reader, options);
          break;

        case "performer":
          Performer = new fhirCsR2.Models.Reference();
          Performer.DeserializeJson(ref reader, options);
          break;

        case "prediction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Prediction = new List<RiskAssessmentPrediction>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.RiskAssessmentPrediction objPrediction = new fhirCsR2.Models.RiskAssessmentPrediction();
            objPrediction.DeserializeJson(ref reader, options);
            Prediction.Add(objPrediction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Prediction.Count == 0)
          {
            Prediction = null;
          }

          break;

        case "subject":
          Subject = new fhirCsR2.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
