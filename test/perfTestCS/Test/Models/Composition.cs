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
  /// Only list each attester once.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<CompositionAttester>))]
  public class CompositionAttester : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The type of attestation the authenticator offers.
    /// </summary>
    public string Mode { get; set; }
    /// <summary>
    /// Extension container element for Mode
    /// </summary>
    public Element _Mode { get; set; }
    /// <summary>
    /// Who attested the composition in the specified way.
    /// </summary>
    public Reference Party { get; set; }
    /// <summary>
    /// When the composition was attested by the party.
    /// </summary>
    public string Time { get; set; }
    /// <summary>
    /// Extension container element for Time
    /// </summary>
    public Element _Time { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "mode":
          Mode = reader.GetString();
          break;

        case "_mode":
          _Mode = new Fhir.R4.Models.Element();
          _Mode.DeserializeJson(ref reader, options);
          break;

        case "party":
          Party = new Fhir.R4.Models.Reference();
          Party.DeserializeJson(ref reader, options);
          break;

        case "time":
          Time = reader.GetString();
          break;

        case "_time":
          _Time = new Fhir.R4.Models.Element();
          _Time.DeserializeJson(ref reader, options);
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
  /// A document is a version specific composition.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<CompositionRelatesTo>))]
  public class CompositionRelatesTo : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// If this document appends another document, then the document cannot be fully understood without also accessing the referenced document.
    /// </summary>
    public string Code { get; set; }
    /// <summary>
    /// Extension container element for Code
    /// </summary>
    public Element _Code { get; set; }
    /// <summary>
    /// The target composition/document of this relationship.
    /// </summary>
    public Identifier TargetIdentifier { get; set; }
    /// <summary>
    /// The target composition/document of this relationship.
    /// </summary>
    public Reference TargetReference { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          Code = reader.GetString();
          break;

        case "_code":
          _Code = new Fhir.R4.Models.Element();
          _Code.DeserializeJson(ref reader, options);
          break;

        case "targetIdentifier":
          TargetIdentifier = new Fhir.R4.Models.Identifier();
          TargetIdentifier.DeserializeJson(ref reader, options);
          break;

        case "targetReference":
          TargetReference = new Fhir.R4.Models.Reference();
          TargetReference.DeserializeJson(ref reader, options);
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
  /// The event needs to be consistent with the type element, though can provide further information if desired.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<CompositionEvent>))]
  public class CompositionEvent : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// An event can further specialize the act inherent in the typeCode, such as where it is simply "Procedure Report" and the procedure was a "colonoscopy". If one or more eventCodes are included, they SHALL NOT conflict with the values inherent in the classCode, practiceSettingCode or typeCode, as such a conflict would create an ambiguous situation. This short list of codes is provided to be used as key words for certain types of queries.
    /// </summary>
    public List<CodeableConcept> Code { get; set; }
    /// <summary>
    /// The description and/or reference of the event(s) being documented. For example, this could be used to document such a colonoscopy or an appendectomy.
    /// </summary>
    public List<Reference> Detail { get; set; }
    /// <summary>
    /// The period of time covered by the documentation. There is no assertion that the documentation is a complete representation for this period, only that it documents events during this time.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Code = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objCode = new Fhir.R4.Models.CodeableConcept();
            objCode.DeserializeJson(ref reader, options);
            Code.Add(objCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Code.Count == 0)
          {
            Code = null;
          }

          break;

        case "detail":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Detail = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objDetail = new Fhir.R4.Models.Reference();
            objDetail.DeserializeJson(ref reader, options);
            Detail.Add(objDetail);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Detail.Count == 0)
          {
            Detail = null;
          }

          break;

        case "period":
          Period = new Fhir.R4.Models.Period();
          Period.DeserializeJson(ref reader, options);
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
  /// The root of the sections that make up the composition.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<CompositionSection>))]
  public class CompositionSection : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Identifies who is responsible for the information in this section, not necessarily who typed it in.
    /// </summary>
    public List<Reference> Author { get; set; }
    /// <summary>
    /// The code identifies the section for an automated processor of the document. This is particularly relevant when using profiles to control the structure of the document.   
    /// If the section has content (instead of sub-sections), the section.code does not change the meaning or interpretation of the resource that is the content of the section in the comments for the section.code.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// The various reasons for an empty section make a significant interpretation to its interpretation. Note that this code is for use when the entire section content has been suppressed, and not for when individual items are omitted - implementers may consider using a text note or a flag on an entry in these cases.
    /// </summary>
    public CodeableConcept EmptyReason { get; set; }
    /// <summary>
    /// If there are no entries in the list, an emptyReason SHOULD be provided.
    /// </summary>
    public List<Reference> Entry { get; set; }
    /// <summary>
    /// Typically, sections in a doument are about the subject of the document, whether that is a  patient, or group of patients, location, or device, or whatever. For some kind of documents, some sections actually contain data about related entities. Typical examples are  a section in a newborn discharge summary concerning the mother, or family history documents, with a section about each family member, though there are many other examples.
    /// </summary>
    public Reference Focus { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because a change list must not be misunderstood as a complete list.
    /// </summary>
    public string Mode { get; set; }
    /// <summary>
    /// Extension container element for Mode
    /// </summary>
    public Element _Mode { get; set; }
    /// <summary>
    /// Applications SHOULD render ordered lists in the order provided, but MAY allow users to re-order based on their own preferences as well. If there is no order specified, the order is unknown, though there may still be some order.
    /// </summary>
    public CodeableConcept OrderedBy { get; set; }
    /// <summary>
    /// Nested sections are primarily used to help human readers navigate to particular portions of the document.
    /// </summary>
    public List<CompositionSection> Section { get; set; }
    /// <summary>
    /// Document profiles may define what content should be represented in the narrative to ensure clinical safety.
    /// </summary>
    public Narrative Text { get; set; }
    /// <summary>
    /// The title identifies the section for a human reader. The title must be consistent with the narrative of the resource that is the target of the section.content reference. Generally, sections SHOULD have titles, but in some documents, it is unnecessary or inappropriate. Typically, this is where a section has subsections that have their own adequately distinguishing title,  or documents that only have a single section. Most Implementation Guides will make section title to be a required element.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Extension container element for Title
    /// </summary>
    public Element _Title { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "author":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Author = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objAuthor = new Fhir.R4.Models.Reference();
            objAuthor.DeserializeJson(ref reader, options);
            Author.Add(objAuthor);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Author.Count == 0)
          {
            Author = null;
          }

          break;

        case "code":
          Code = new Fhir.R4.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "emptyReason":
          EmptyReason = new Fhir.R4.Models.CodeableConcept();
          EmptyReason.DeserializeJson(ref reader, options);
          break;

        case "entry":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Entry = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objEntry = new Fhir.R4.Models.Reference();
            objEntry.DeserializeJson(ref reader, options);
            Entry.Add(objEntry);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Entry.Count == 0)
          {
            Entry = null;
          }

          break;

        case "focus":
          Focus = new Fhir.R4.Models.Reference();
          Focus.DeserializeJson(ref reader, options);
          break;

        case "mode":
          Mode = reader.GetString();
          break;

        case "_mode":
          _Mode = new Fhir.R4.Models.Element();
          _Mode.DeserializeJson(ref reader, options);
          break;

        case "orderedBy":
          OrderedBy = new Fhir.R4.Models.CodeableConcept();
          OrderedBy.DeserializeJson(ref reader, options);
          break;

        case "section":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Section = new List<CompositionSection>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CompositionSection objSection = new Fhir.R4.Models.CompositionSection();
            objSection.DeserializeJson(ref reader, options);
            Section.Add(objSection);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Section.Count == 0)
          {
            Section = null;
          }

          break;

        case "text":
          Text = new Fhir.R4.Models.Narrative();
          Text.DeserializeJson(ref reader, options);
          break;

        case "title":
          Title = reader.GetString();
          break;

        case "_title":
          _Title = new Fhir.R4.Models.Element();
          _Title.DeserializeJson(ref reader, options);
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
  /// A set of healthcare-related information that is assembled together into a single logical package that provides a single coherent statement of meaning, establishes its own context and that has clinical attestation with regard to who is making the statement. A Composition defines the structure and narrative content necessary for a document. However, a Composition alone does not constitute a document. Rather, the Composition must be the first entry in a Bundle where Bundle.type=document, and any other resources referenced from Composition must be included as subsequent entries in the Bundle (for example Patient, Practitioner, Encounter, etc.).
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonResourceConverter))]
  public class Composition : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "Composition";
    /// <summary>
    /// Only list each attester once.
    /// </summary>
    public List<CompositionAttester> Attester { get; set; }
    /// <summary>
    /// Identifies who is responsible for the information in the composition, not necessarily who typed it in.
    /// </summary>
    public List<Reference> Author { get; set; }
    /// <summary>
    /// This is a metadata field from [XDS/MHD](http://wiki.ihe.net/index.php?title=Mobile_access_to_Health_Documents_(MHD)).
    /// </summary>
    public List<CodeableConcept> Category { get; set; }
    /// <summary>
    /// The exact use of this element, and enforcement and issues related to highly sensitive documents are out of scope for the base specification, and delegated to implementation profiles (see security section).  This element is labeled as a modifier because highly confidential documents must not be treated as if they are not.
    /// </summary>
    public string Confidentiality { get; set; }
    /// <summary>
    /// Extension container element for Confidentiality
    /// </summary>
    public Element _Confidentiality { get; set; }
    /// <summary>
    /// This is useful when documents are derived from a composition - provides guidance for how to get the latest version of the document. This is optional because this is sometimes not known by the authoring system, and can be inferred by context. However, it is important that this information be known when working with a derived document, so providing a custodian is encouraged.
    /// </summary>
    public Reference Custodian { get; set; }
    /// <summary>
    /// The Last Modified Date on the composition may be after the date of the document was attested without being changed.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// Describes the clinical encounter or type of care this documentation is associated with.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// The event needs to be consistent with the type element, though can provide further information if desired.
    /// </summary>
    public List<CompositionEvent> Event { get; set; }
    /// <summary>
    /// Similar to ClinicalDocument/setId in CDA. See discussion in resource definition for how these relate.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// A document is a version specific composition.
    /// </summary>
    public List<CompositionRelatesTo> RelatesTo { get; set; }
    /// <summary>
    /// The root of the sections that make up the composition.
    /// </summary>
    public List<CompositionSection> Section { get; set; }
    /// <summary>
    /// If a composition is marked as withdrawn, the compositions/documents in the series, or data from the composition or document series, should never be displayed to a user without being clearly marked as untrustworthy. The flag "entered-in-error" is why this element is labeled as a modifier of other elements.   
    /// Some reporting work flows require that the original narrative of a final document never be altered; instead, only new narrative can be added. The composition resource has no explicit status for explicitly noting whether this business rule is in effect. This would be handled by an extension if required.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// For clinical documents, this is usually the patient.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// For many compositions, the title is the same as the text or a display name of Composition.type (e.g. a "consultation" or "progress note"). Note that CDA does not make title mandatory, but there are no known cases where it is useful for title to be omitted, so it is mandatory here. Feedback on this requirement is welcome during the trial use period.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Extension container element for Title
    /// </summary>
    public Element _Title { get; set; }
    /// <summary>
    /// For Composition type, LOINC is ubiquitous and strongly endorsed by HL7. Most implementation guides will require a specific LOINC code, or use LOINC as an extensible binding.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "attester":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Attester = new List<CompositionAttester>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CompositionAttester objAttester = new Fhir.R4.Models.CompositionAttester();
            objAttester.DeserializeJson(ref reader, options);
            Attester.Add(objAttester);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Attester.Count == 0)
          {
            Attester = null;
          }

          break;

        case "author":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Author = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objAuthor = new Fhir.R4.Models.Reference();
            objAuthor.DeserializeJson(ref reader, options);
            Author.Add(objAuthor);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Author.Count == 0)
          {
            Author = null;
          }

          break;

        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objCategory = new Fhir.R4.Models.CodeableConcept();
            objCategory.DeserializeJson(ref reader, options);
            Category.Add(objCategory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Category.Count == 0)
          {
            Category = null;
          }

          break;

        case "confidentiality":
          Confidentiality = reader.GetString();
          break;

        case "_confidentiality":
          _Confidentiality = new Fhir.R4.Models.Element();
          _Confidentiality.DeserializeJson(ref reader, options);
          break;

        case "custodian":
          Custodian = new Fhir.R4.Models.Reference();
          Custodian.DeserializeJson(ref reader, options);
          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new Fhir.R4.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          Encounter = new Fhir.R4.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
          break;

        case "event":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Event = new List<CompositionEvent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CompositionEvent objEvent = new Fhir.R4.Models.CompositionEvent();
            objEvent.DeserializeJson(ref reader, options);
            Event.Add(objEvent);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Event.Count == 0)
          {
            Event = null;
          }

          break;

        case "identifier":
          Identifier = new Fhir.R4.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "relatesTo":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          RelatesTo = new List<CompositionRelatesTo>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CompositionRelatesTo objRelatesTo = new Fhir.R4.Models.CompositionRelatesTo();
            objRelatesTo.DeserializeJson(ref reader, options);
            RelatesTo.Add(objRelatesTo);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (RelatesTo.Count == 0)
          {
            RelatesTo = null;
          }

          break;

        case "section":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Section = new List<CompositionSection>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CompositionSection objSection = new Fhir.R4.Models.CompositionSection();
            objSection.DeserializeJson(ref reader, options);
            Section.Add(objSection);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Section.Count == 0)
          {
            Section = null;
          }

          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new Fhir.R4.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "title":
          Title = reader.GetString();
          break;

        case "_title":
          _Title = new Fhir.R4.Models.Element();
          _Title.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new Fhir.R4.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
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
