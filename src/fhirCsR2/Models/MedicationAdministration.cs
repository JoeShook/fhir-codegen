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
  /// Describes the medication dosage information details e.g. dose, rate, site, route, etc.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<MedicationAdministrationDosage>))]
  public class MedicationAdministrationDosage : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A coded value indicating the method by which the medication is intended to be or was introduced into or on the body.  This attribute will most often NOT be populated.  It is most commonly used for injections.  For example, Slow Push, Deep IV.
    /// </summary>
    public CodeableConcept Method { get; set; }
    /// <summary>
    /// The amount of the medication given at one administration event.   Use this value when the administration is essentially an instantaneous event such as a swallowing a tablet or giving an injection.
    /// </summary>
    public Quantity Quantity { get; set; }
    /// <summary>
    /// Identifies the speed with which the medication was or will be introduced into the patient.  Typically the rate for an infusion e.g. 100 ml per 1 hour or 100 ml/hr.  May also be expressed as a rate per unit of time e.g. 500 ml per 2 hours.  Currently we do not specify a default of '1' in the denominator, but this is being discussed.  Other examples:  200 mcg/min or 200 mcg/1 minute; 1 liter/8 hours.
    /// </summary>
    public Ratio RateRatio { get; set; }
    /// <summary>
    /// Identifies the speed with which the medication was or will be introduced into the patient.  Typically the rate for an infusion e.g. 100 ml per 1 hour or 100 ml/hr.  May also be expressed as a rate per unit of time e.g. 500 ml per 2 hours.  Currently we do not specify a default of '1' in the denominator, but this is being discussed.  Other examples:  200 mcg/min or 200 mcg/1 minute; 1 liter/8 hours.
    /// </summary>
    public Range RateRange { get; set; }
    /// <summary>
    /// A code specifying the route or physiological path of administration of a therapeutic agent into or onto the patient.  For example, topical, intravenous, etc.
    /// </summary>
    public CodeableConcept Route { get; set; }
    /// <summary>
    /// A coded specification of the anatomic site where the medication first entered the body.  For example, "left arm".
    /// </summary>
    public CodeableConcept SiteCodeableConcept { get; set; }
    /// <summary>
    /// A coded specification of the anatomic site where the medication first entered the body.  For example, "left arm".
    /// </summary>
    public Reference SiteReference { get; set; }
    /// <summary>
    /// Free text dosage instructions can be used for cases where the instructions are too complex to code. When coded instructions are present, the free text instructions may still be present for display to humans taking or administering the medication.
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Extension container element for Text
    /// </summary>
    public Element _Text { get; set; }
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

      if (!string.IsNullOrEmpty(Text))
      {
        writer.WriteString("text", (string)Text!);
      }

      if (_Text != null)
      {
        writer.WritePropertyName("_text");
        _Text.SerializeJson(writer, options);
      }

      if (SiteCodeableConcept != null)
      {
        writer.WritePropertyName("siteCodeableConcept");
        SiteCodeableConcept.SerializeJson(writer, options);
      }

      if (SiteReference != null)
      {
        writer.WritePropertyName("siteReference");
        SiteReference.SerializeJson(writer, options);
      }

      if (Route != null)
      {
        writer.WritePropertyName("route");
        Route.SerializeJson(writer, options);
      }

      if (Method != null)
      {
        writer.WritePropertyName("method");
        Method.SerializeJson(writer, options);
      }

      if (Quantity != null)
      {
        writer.WritePropertyName("quantity");
        Quantity.SerializeJson(writer, options);
      }

      if (RateRatio != null)
      {
        writer.WritePropertyName("rateRatio");
        RateRatio.SerializeJson(writer, options);
      }

      if (RateRange != null)
      {
        writer.WritePropertyName("rateRange");
        RateRange.SerializeJson(writer, options);
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
        case "method":
          Method = new fhirCsR2.Models.CodeableConcept();
          Method.DeserializeJson(ref reader, options);
          break;

        case "quantity":
          Quantity = new fhirCsR2.Models.Quantity();
          Quantity.DeserializeJson(ref reader, options);
          break;

        case "rateRatio":
          RateRatio = new fhirCsR2.Models.Ratio();
          RateRatio.DeserializeJson(ref reader, options);
          break;

        case "rateRange":
          RateRange = new fhirCsR2.Models.Range();
          RateRange.DeserializeJson(ref reader, options);
          break;

        case "route":
          Route = new fhirCsR2.Models.CodeableConcept();
          Route.DeserializeJson(ref reader, options);
          break;

        case "siteCodeableConcept":
          SiteCodeableConcept = new fhirCsR2.Models.CodeableConcept();
          SiteCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "siteReference":
          SiteReference = new fhirCsR2.Models.Reference();
          SiteReference.DeserializeJson(ref reader, options);
          break;

        case "text":
          Text = reader.GetString();
          break;

        case "_text":
          _Text = new fhirCsR2.Models.Element();
          _Text.DeserializeJson(ref reader, options);
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
  /// Describes the event of a patient consuming or otherwise being administered a medication.  This may be as simple as swallowing a tablet or it may be a long running infusion.  Related resources tie this event to the authorizing prescription, and the specific encounter between patient and health care practitioner.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<MedicationAdministration>))]
  public class MedicationAdministration : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "MedicationAdministration";
    /// <summary>
    /// The device used in administering the medication to the patient.  For example, a particular infusion pump.
    /// </summary>
    public List<Reference> Device { get; set; }
    /// <summary>
    /// Describes the medication dosage information details e.g. dose, rate, site, route, etc.
    /// </summary>
    public MedicationAdministrationDosage Dosage { get; set; }
    /// <summary>
    /// A specific date/time or interval of time during which the administration took place (or did not take place, when the 'notGiven' attribute is true). For many administrations, such as swallowing a tablet the use of dateTime is more appropriate.
    /// </summary>
    public string EffectiveTimeDateTime { get; set; }
    /// <summary>
    /// Extension container element for EffectiveTimeDateTime
    /// </summary>
    public Element _EffectiveTimeDateTime { get; set; }
    /// <summary>
    /// A specific date/time or interval of time during which the administration took place (or did not take place, when the 'notGiven' attribute is true). For many administrations, such as swallowing a tablet the use of dateTime is more appropriate.
    /// </summary>
    public Period EffectiveTimePeriod { get; set; }
    /// <summary>
    /// The visit, admission or other contact between patient and health care provider the medication administration was performed as part of.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// External identifier - FHIR will generate its own internal identifiers (probably URLs) which do not need to be explicitly managed by the resource.  The identifier here is one that would be used by another non-FHIR system - for example an automated medication pump would provide a record each time it operated; an administration while the patient was off the ward might be made with a different system and entered after the event.  Particularly important if these records have to be updated.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Identifies the medication that was administered. This is either a link to a resource representing the details of the medication or a simple attribute carrying a code that identifies the medication from a known list of medications.
    /// </summary>
    public CodeableConcept MedicationCodeableConcept { get; set; }
    /// <summary>
    /// Identifies the medication that was administered. This is either a link to a resource representing the details of the medication or a simple attribute carrying a code that identifies the medication from a known list of medications.
    /// </summary>
    public Reference MedicationReference { get; set; }
    /// <summary>
    /// Extra information about the medication administration that is not conveyed by the other attributes.
    /// </summary>
    public string Note { get; set; }
    /// <summary>
    /// Extension container element for Note
    /// </summary>
    public Element _Note { get; set; }
    /// <summary>
    /// The person or animal receiving the medication.
    /// </summary>
    public Reference Patient { get; set; }
    /// <summary>
    /// The individual who was responsible for giving the medication to the patient.
    /// </summary>
    public Reference Practitioner { get; set; }
    /// <summary>
    /// The original request, instruction or authority to perform the administration.
    /// </summary>
    public Reference Prescription { get; set; }
    /// <summary>
    /// A code indicating why the medication was given.
    /// </summary>
    public List<CodeableConcept> ReasonGiven { get; set; }
    /// <summary>
    /// A code indicating why the administration was not performed.
    /// </summary>
    public List<CodeableConcept> ReasonNotGiven { get; set; }
    /// <summary>
    /// Will generally be set to show that the administration has been completed.  For some long running administrations such as infusions it is possible for an administration to be started but not completed or it may be paused while some other process is under way.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Set this to true if the record is saying that the medication was NOT administered.
    /// </summary>
    public bool? WasNotGiven { get; set; }
    /// <summary>
    /// Extension container element for WasNotGiven
    /// </summary>
    public Element _WasNotGiven { get; set; }
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

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (Patient != null)
      {
        writer.WritePropertyName("patient");
        Patient.SerializeJson(writer, options);
      }

      if (Practitioner != null)
      {
        writer.WritePropertyName("practitioner");
        Practitioner.SerializeJson(writer, options);
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(writer, options);
      }

      if (Prescription != null)
      {
        writer.WritePropertyName("prescription");
        Prescription.SerializeJson(writer, options);
      }

      if (WasNotGiven != null)
      {
        writer.WriteBoolean("wasNotGiven", (bool)WasNotGiven!);
      }

      if (_WasNotGiven != null)
      {
        writer.WritePropertyName("_wasNotGiven");
        _WasNotGiven.SerializeJson(writer, options);
      }

      if ((ReasonNotGiven != null) && (ReasonNotGiven.Count != 0))
      {
        writer.WritePropertyName("reasonNotGiven");
        writer.WriteStartArray();

        foreach (CodeableConcept valReasonNotGiven in ReasonNotGiven)
        {
          valReasonNotGiven.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ReasonGiven != null) && (ReasonGiven.Count != 0))
      {
        writer.WritePropertyName("reasonGiven");
        writer.WriteStartArray();

        foreach (CodeableConcept valReasonGiven in ReasonGiven)
        {
          valReasonGiven.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(EffectiveTimeDateTime))
      {
        writer.WriteString("effectiveTimeDateTime", (string)EffectiveTimeDateTime!);
      }

      if (_EffectiveTimeDateTime != null)
      {
        writer.WritePropertyName("_effectiveTimeDateTime");
        _EffectiveTimeDateTime.SerializeJson(writer, options);
      }

      if (EffectiveTimePeriod != null)
      {
        writer.WritePropertyName("effectiveTimePeriod");
        EffectiveTimePeriod.SerializeJson(writer, options);
      }

      if (MedicationCodeableConcept != null)
      {
        writer.WritePropertyName("medicationCodeableConcept");
        MedicationCodeableConcept.SerializeJson(writer, options);
      }

      if (MedicationReference != null)
      {
        writer.WritePropertyName("medicationReference");
        MedicationReference.SerializeJson(writer, options);
      }

      if ((Device != null) && (Device.Count != 0))
      {
        writer.WritePropertyName("device");
        writer.WriteStartArray();

        foreach (Reference valDevice in Device)
        {
          valDevice.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Note))
      {
        writer.WriteString("note", (string)Note!);
      }

      if (_Note != null)
      {
        writer.WritePropertyName("_note");
        _Note.SerializeJson(writer, options);
      }

      if (Dosage != null)
      {
        writer.WritePropertyName("dosage");
        Dosage.SerializeJson(writer, options);
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
        case "device":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Device = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Reference objDevice = new fhirCsR2.Models.Reference();
            objDevice.DeserializeJson(ref reader, options);
            Device.Add(objDevice);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Device.Count == 0)
          {
            Device = null;
          }

          break;

        case "dosage":
          Dosage = new fhirCsR2.Models.MedicationAdministrationDosage();
          Dosage.DeserializeJson(ref reader, options);
          break;

        case "effectiveTimeDateTime":
          EffectiveTimeDateTime = reader.GetString();
          break;

        case "_effectiveTimeDateTime":
          _EffectiveTimeDateTime = new fhirCsR2.Models.Element();
          _EffectiveTimeDateTime.DeserializeJson(ref reader, options);
          break;

        case "effectiveTimePeriod":
          EffectiveTimePeriod = new fhirCsR2.Models.Period();
          EffectiveTimePeriod.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          Encounter = new fhirCsR2.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Identifier objIdentifier = new fhirCsR2.Models.Identifier();
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

        case "medicationCodeableConcept":
          MedicationCodeableConcept = new fhirCsR2.Models.CodeableConcept();
          MedicationCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "medicationReference":
          MedicationReference = new fhirCsR2.Models.Reference();
          MedicationReference.DeserializeJson(ref reader, options);
          break;

        case "note":
          Note = reader.GetString();
          break;

        case "_note":
          _Note = new fhirCsR2.Models.Element();
          _Note.DeserializeJson(ref reader, options);
          break;

        case "patient":
          Patient = new fhirCsR2.Models.Reference();
          Patient.DeserializeJson(ref reader, options);
          break;

        case "practitioner":
          Practitioner = new fhirCsR2.Models.Reference();
          Practitioner.DeserializeJson(ref reader, options);
          break;

        case "prescription":
          Prescription = new fhirCsR2.Models.Reference();
          Prescription.DeserializeJson(ref reader, options);
          break;

        case "reasonGiven":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonGiven = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.CodeableConcept objReasonGiven = new fhirCsR2.Models.CodeableConcept();
            objReasonGiven.DeserializeJson(ref reader, options);
            ReasonGiven.Add(objReasonGiven);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReasonGiven.Count == 0)
          {
            ReasonGiven = null;
          }

          break;

        case "reasonNotGiven":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonNotGiven = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.CodeableConcept objReasonNotGiven = new fhirCsR2.Models.CodeableConcept();
            objReasonNotGiven.DeserializeJson(ref reader, options);
            ReasonNotGiven.Add(objReasonNotGiven);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReasonNotGiven.Count == 0)
          {
            ReasonNotGiven = null;
          }

          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR2.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "wasNotGiven":
          WasNotGiven = reader.GetBoolean();
          break;

        case "_wasNotGiven":
          _WasNotGiven = new fhirCsR2.Models.Element();
          _WasNotGiven.DeserializeJson(ref reader, options);
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
  /// <summary>
  /// Code Values for the MedicationAdministration.status field
  /// </summary>
  public static class MedicationAdministrationStatusCodes {
    public const string IN_PROGRESS = "in-progress";
    public const string ON_HOLD = "on-hold";
    public const string COMPLETED = "completed";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string STOPPED = "stopped";
    public static HashSet<string> Values = new HashSet<string>() {
      "in-progress",
      "on-hold",
      "completed",
      "entered-in-error",
      "stopped",
    };
  }
}