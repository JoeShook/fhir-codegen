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
  /// Compartment Consistency Rules.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<GraphDefinitionLinkTargetCompartment>))]
  public class GraphDefinitionLinkTargetCompartment : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Identifies the compartment.
    /// </summary>
    public string Code { get; set; }
    /// <summary>
    /// Extension container element for Code
    /// </summary>
    public Element _Code { get; set; }
    /// <summary>
    /// Documentation for FHIRPath expression.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// Custom rule, as a FHIRPath expression.
    /// </summary>
    public string Expression { get; set; }
    /// <summary>
    /// Extension container element for Expression
    /// </summary>
    public Element _Expression { get; set; }
    /// <summary>
    /// identical | matching | different | no-rule | custom.
    /// </summary>
    public string Rule { get; set; }
    /// <summary>
    /// Extension container element for Rule
    /// </summary>
    public Element _Rule { get; set; }
    /// <summary>
    /// All conditional rules are evaluated; if they are true, then the rules are evaluated.
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

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(ref writer, options, false);

      if (!string.IsNullOrEmpty(Use))
      {
        writer.WriteString("use", (string)Use!);
      }

      if (_Use != null)
      {
        writer.WritePropertyName("_use");
        _Use.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Code))
      {
        writer.WriteString("code", (string)Code!);
      }

      if (_Code != null)
      {
        writer.WritePropertyName("_code");
        _Code.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Rule))
      {
        writer.WriteString("rule", (string)Rule!);
      }

      if (_Rule != null)
      {
        writer.WritePropertyName("_rule");
        _Rule.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Expression))
      {
        writer.WriteString("expression", (string)Expression!);
      }

      if (_Expression != null)
      {
        writer.WritePropertyName("_expression");
        _Expression.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Description))
      {
        writer.WriteString("description", (string)Description!);
      }

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(ref writer, options);
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
          Code = reader.GetString();
          break;

        case "_code":
          _Code = new Fhir.R4.Models.Element();
          _Code.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new Fhir.R4.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "expression":
          Expression = reader.GetString();
          break;

        case "_expression":
          _Expression = new Fhir.R4.Models.Element();
          _Expression.DeserializeJson(ref reader, options);
          break;

        case "rule":
          Rule = reader.GetString();
          break;

        case "_rule":
          _Rule = new Fhir.R4.Models.Element();
          _Rule.DeserializeJson(ref reader, options);
          break;

        case "use":
          Use = reader.GetString();
          break;

        case "_use":
          _Use = new Fhir.R4.Models.Element();
          _Use.DeserializeJson(ref reader, options);
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
  /// Potential target for the link.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<GraphDefinitionLinkTarget>))]
  public class GraphDefinitionLinkTarget : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Compartment Consistency Rules.
    /// </summary>
    public List<GraphDefinitionLinkTargetCompartment> Compartment { get; set; }
    /// <summary>
    /// Additional links from target resource.
    /// </summary>
    public List<GraphDefinitionLink> Link { get; set; }
    /// <summary>
    /// At least one of the parameters must have the value {ref} which identifies the focus resource.
    /// </summary>
    public string Params { get; set; }
    /// <summary>
    /// Extension container element for Params
    /// </summary>
    public Element _Params { get; set; }
    /// <summary>
    /// Profile for the target resource.
    /// </summary>
    public string Profile { get; set; }
    /// <summary>
    /// Extension container element for Profile
    /// </summary>
    public Element _Profile { get; set; }
    /// <summary>
    /// Type of resource this link refers to.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
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

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Params))
      {
        writer.WriteString("params", (string)Params!);
      }

      if (_Params != null)
      {
        writer.WritePropertyName("_params");
        _Params.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Profile))
      {
        writer.WriteString("profile", (string)Profile!);
      }

      if (_Profile != null)
      {
        writer.WritePropertyName("_profile");
        _Profile.SerializeJson(ref writer, options);
      }

      if ((Compartment != null) && (Compartment.Count != 0))
      {
        writer.WritePropertyName("compartment");
        writer.WriteStartArray();

        foreach (GraphDefinitionLinkTargetCompartment valCompartment in Compartment)
        {
          valCompartment.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Link != null) && (Link.Count != 0))
      {
        writer.WritePropertyName("link");
        writer.WriteStartArray();

        foreach (GraphDefinitionLink valLink in Link)
        {
          valLink.SerializeJson(ref writer, options, true);
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
        case "compartment":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Compartment = new List<GraphDefinitionLinkTargetCompartment>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.GraphDefinitionLinkTargetCompartment objCompartment = new Fhir.R4.Models.GraphDefinitionLinkTargetCompartment();
            objCompartment.DeserializeJson(ref reader, options);
            Compartment.Add(objCompartment);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Compartment.Count == 0)
          {
            Compartment = null;
          }

          break;

        case "link":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Link = new List<GraphDefinitionLink>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.GraphDefinitionLink objLink = new Fhir.R4.Models.GraphDefinitionLink();
            objLink.DeserializeJson(ref reader, options);
            Link.Add(objLink);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Link.Count == 0)
          {
            Link = null;
          }

          break;

        case "params":
          Params = reader.GetString();
          break;

        case "_params":
          _Params = new Fhir.R4.Models.Element();
          _Params.DeserializeJson(ref reader, options);
          break;

        case "profile":
          Profile = reader.GetString();
          break;

        case "_profile":
          _Profile = new Fhir.R4.Models.Element();
          _Profile.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new Fhir.R4.Models.Element();
          _Type.DeserializeJson(ref reader, options);
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
  /// Links this graph makes rules about.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<GraphDefinitionLink>))]
  public class GraphDefinitionLink : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Information about why this link is of interest in this graph definition.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// Maximum occurrences for this link.
    /// </summary>
    public string Max { get; set; }
    /// <summary>
    /// Extension container element for Max
    /// </summary>
    public Element _Max { get; set; }
    /// <summary>
    /// Minimum occurrences for this link.
    /// </summary>
    public int? Min { get; set; }
    /// <summary>
    /// The path expression cannot contain a resolve() function. If there is no path, the link is a reverse lookup, using target.params. If the path is "*" then this means all references in the resource.
    /// </summary>
    public string Path { get; set; }
    /// <summary>
    /// Extension container element for Path
    /// </summary>
    public Element _Path { get; set; }
    /// <summary>
    /// Which slice (if profiled).
    /// </summary>
    public string SliceName { get; set; }
    /// <summary>
    /// Extension container element for SliceName
    /// </summary>
    public Element _SliceName { get; set; }
    /// <summary>
    /// Potential target for the link.
    /// </summary>
    public List<GraphDefinitionLinkTarget> Target { get; set; }
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

      if (!string.IsNullOrEmpty(Path))
      {
        writer.WriteString("path", (string)Path!);
      }

      if (_Path != null)
      {
        writer.WritePropertyName("_path");
        _Path.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(SliceName))
      {
        writer.WriteString("sliceName", (string)SliceName!);
      }

      if (_SliceName != null)
      {
        writer.WritePropertyName("_sliceName");
        _SliceName.SerializeJson(ref writer, options);
      }

      if (Min != null)
      {
        writer.WriteNumber("min", (int)Min!);
      }

      if (!string.IsNullOrEmpty(Max))
      {
        writer.WriteString("max", (string)Max!);
      }

      if (_Max != null)
      {
        writer.WritePropertyName("_max");
        _Max.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Description))
      {
        writer.WriteString("description", (string)Description!);
      }

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(ref writer, options);
      }

      if ((Target != null) && (Target.Count != 0))
      {
        writer.WritePropertyName("target");
        writer.WriteStartArray();

        foreach (GraphDefinitionLinkTarget valTarget in Target)
        {
          valTarget.SerializeJson(ref writer, options, true);
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
        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new Fhir.R4.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "max":
          Max = reader.GetString();
          break;

        case "_max":
          _Max = new Fhir.R4.Models.Element();
          _Max.DeserializeJson(ref reader, options);
          break;

        case "min":
          Min = reader.GetInt32();
          break;

        case "path":
          Path = reader.GetString();
          break;

        case "_path":
          _Path = new Fhir.R4.Models.Element();
          _Path.DeserializeJson(ref reader, options);
          break;

        case "sliceName":
          SliceName = reader.GetString();
          break;

        case "_sliceName":
          _SliceName = new Fhir.R4.Models.Element();
          _SliceName.DeserializeJson(ref reader, options);
          break;

        case "target":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Target = new List<GraphDefinitionLinkTarget>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.GraphDefinitionLinkTarget objTarget = new Fhir.R4.Models.GraphDefinitionLinkTarget();
            objTarget.DeserializeJson(ref reader, options);
            Target.Add(objTarget);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Target.Count == 0)
          {
            Target = null;
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
  /// A formal computable definition of a graph of resources - that is, a coherent set of resources that form a graph by following references. The Graph Definition resource defines a set and makes rules about the set.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<GraphDefinition>))]
  public class GraphDefinition : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "GraphDefinition";
    /// <summary>
    /// May be a web site, an email address, a telephone number, etc.
    /// </summary>
    public List<ContactDetail> Contact { get; set; }
    /// <summary>
    /// Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the graph definition. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// This description can be used to capture details such as why the graph definition was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the graph definition as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the graph definition is presumed to be the predominant language in the place the graph definition was created).
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// Allows filtering of graph definitions that are appropriate for use versus not.
    /// </summary>
    public bool? Experimental { get; set; }
    /// <summary>
    /// It may be possible for the graph definition to be used in jurisdictions other than those for which it was originally designed or intended.
    /// </summary>
    public List<CodeableConcept> Jurisdiction { get; set; }
    /// <summary>
    /// Links this graph makes rules about.
    /// </summary>
    public List<GraphDefinitionLink> Link { get; set; }
    /// <summary>
    /// The name is not expected to be globally unique. The name should be a simple alphanumeric type name to ensure that it is machine-processing friendly.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// The code does not include the '$' prefix that is always included in the URL when the operation is invoked.
    /// </summary>
    public string Profile { get; set; }
    /// <summary>
    /// Extension container element for Profile
    /// </summary>
    public Element _Profile { get; set; }
    /// <summary>
    /// Usually an organization but may be an individual. The publisher (or steward) of the graph definition is the organization or individual primarily responsible for the maintenance and upkeep of the graph definition. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the graph definition. This item SHOULD be populated unless the information is available from context.
    /// </summary>
    public string Publisher { get; set; }
    /// <summary>
    /// Extension container element for Publisher
    /// </summary>
    public Element _Publisher { get; set; }
    /// <summary>
    /// This element does not describe the usage of the graph definition. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this graph definition.
    /// </summary>
    public string Purpose { get; set; }
    /// <summary>
    /// Extension container element for Purpose
    /// </summary>
    public Element _Purpose { get; set; }
    /// <summary>
    /// The type of FHIR resource at which instances of this graph start.
    /// </summary>
    public string Start { get; set; }
    /// <summary>
    /// Extension container element for Start
    /// </summary>
    public Element _Start { get; set; }
    /// <summary>
    /// Allows filtering of graph definitions that are appropriate for use versus not.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.
    /// The determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). 
    /// In some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.
    /// </summary>
    public string Url { get; set; }
    /// <summary>
    /// Extension container element for Url
    /// </summary>
    public Element _Url { get; set; }
    /// <summary>
    /// When multiple useContexts are specified, there is no expectation that all or any of the contexts apply.
    /// </summary>
    public List<UsageContext> UseContext { get; set; }
    /// <summary>
    /// There may be different graph definition instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the graph definition with the format [url]|[version].
    /// </summary>
    public string Version { get; set; }
    /// <summary>
    /// Extension container element for Version
    /// </summary>
    public Element _Version { get; set; }
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

      if (!string.IsNullOrEmpty(Url))
      {
        writer.WriteString("url", (string)Url!);
      }

      if (_Url != null)
      {
        writer.WritePropertyName("_url");
        _Url.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Version))
      {
        writer.WriteString("version", (string)Version!);
      }

      if (_Version != null)
      {
        writer.WritePropertyName("_version");
        _Version.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Name))
      {
        writer.WriteString("name", (string)Name!);
      }

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(ref writer, options);
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

      if (Experimental != null)
      {
        writer.WriteBoolean("experimental", (bool)Experimental!);
      }

      if (!string.IsNullOrEmpty(Date))
      {
        writer.WriteString("date", (string)Date!);
      }

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Publisher))
      {
        writer.WriteString("publisher", (string)Publisher!);
      }

      if (_Publisher != null)
      {
        writer.WritePropertyName("_publisher");
        _Publisher.SerializeJson(ref writer, options);
      }

      if ((Contact != null) && (Contact.Count != 0))
      {
        writer.WritePropertyName("contact");
        writer.WriteStartArray();

        foreach (ContactDetail valContact in Contact)
        {
          valContact.SerializeJson(ref writer, options, true);
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
        _Description.SerializeJson(ref writer, options);
      }

      if ((UseContext != null) && (UseContext.Count != 0))
      {
        writer.WritePropertyName("useContext");
        writer.WriteStartArray();

        foreach (UsageContext valUseContext in UseContext)
        {
          valUseContext.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Jurisdiction != null) && (Jurisdiction.Count != 0))
      {
        writer.WritePropertyName("jurisdiction");
        writer.WriteStartArray();

        foreach (CodeableConcept valJurisdiction in Jurisdiction)
        {
          valJurisdiction.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Purpose))
      {
        writer.WriteString("purpose", (string)Purpose!);
      }

      if (_Purpose != null)
      {
        writer.WritePropertyName("_purpose");
        _Purpose.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Start))
      {
        writer.WriteString("start", (string)Start!);
      }

      if (_Start != null)
      {
        writer.WritePropertyName("_start");
        _Start.SerializeJson(ref writer, options);
      }

      if (!string.IsNullOrEmpty(Profile))
      {
        writer.WriteString("profile", (string)Profile!);
      }

      if (_Profile != null)
      {
        writer.WritePropertyName("_profile");
        _Profile.SerializeJson(ref writer, options);
      }

      if ((Link != null) && (Link.Count != 0))
      {
        writer.WritePropertyName("link");
        writer.WriteStartArray();

        foreach (GraphDefinitionLink valLink in Link)
        {
          valLink.SerializeJson(ref writer, options, true);
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
        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Contact = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.ContactDetail objContact = new Fhir.R4.Models.ContactDetail();
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

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new Fhir.R4.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new Fhir.R4.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "experimental":
          Experimental = reader.GetBoolean();
          break;

        case "jurisdiction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Jurisdiction = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objJurisdiction = new Fhir.R4.Models.CodeableConcept();
            objJurisdiction.DeserializeJson(ref reader, options);
            Jurisdiction.Add(objJurisdiction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Jurisdiction.Count == 0)
          {
            Jurisdiction = null;
          }

          break;

        case "link":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Link = new List<GraphDefinitionLink>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.GraphDefinitionLink objLink = new Fhir.R4.Models.GraphDefinitionLink();
            objLink.DeserializeJson(ref reader, options);
            Link.Add(objLink);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Link.Count == 0)
          {
            Link = null;
          }

          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new Fhir.R4.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "profile":
          Profile = reader.GetString();
          break;

        case "_profile":
          _Profile = new Fhir.R4.Models.Element();
          _Profile.DeserializeJson(ref reader, options);
          break;

        case "publisher":
          Publisher = reader.GetString();
          break;

        case "_publisher":
          _Publisher = new Fhir.R4.Models.Element();
          _Publisher.DeserializeJson(ref reader, options);
          break;

        case "purpose":
          Purpose = reader.GetString();
          break;

        case "_purpose":
          _Purpose = new Fhir.R4.Models.Element();
          _Purpose.DeserializeJson(ref reader, options);
          break;

        case "start":
          Start = reader.GetString();
          break;

        case "_start":
          _Start = new Fhir.R4.Models.Element();
          _Start.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "url":
          Url = reader.GetString();
          break;

        case "_url":
          _Url = new Fhir.R4.Models.Element();
          _Url.DeserializeJson(ref reader, options);
          break;

        case "useContext":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          UseContext = new List<UsageContext>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.UsageContext objUseContext = new Fhir.R4.Models.UsageContext();
            objUseContext.DeserializeJson(ref reader, options);
            UseContext.Add(objUseContext);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (UseContext.Count == 0)
          {
            UseContext = null;
          }

          break;

        case "version":
          Version = reader.GetString();
          break;

        case "_version":
          _Version = new Fhir.R4.Models.Element();
          _Version.DeserializeJson(ref reader, options);
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
