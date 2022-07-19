// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This example value set defines a set of codes that can be used to indicate the role of one Organization in relation to another.
  /// </summary>
  public static class OrganizationRoleCodes
  {
    /// <summary>
    /// An organization such as a public health agency, community/social services provider, etc.
    /// </summary>
    public static readonly Coding Agency = new Coding
    {
      Code = "agency",
      Display = "Agency",
      System = "http://hl7.org/fhir/organization-role"
    };
    /// <summary>
    /// An organization providing diagnostic testing/laboratory services
    /// </summary>
    public static readonly Coding Diagnostics = new Coding
    {
      Code = "diagnostics",
      Display = "Diagnostics",
      System = "http://hl7.org/fhir/organization-role"
    };
    /// <summary>
    /// An organization that facilitates electronic clinical data exchange between entities
    /// </summary>
    public static readonly Coding HIEHIO = new Coding
    {
      Code = "HIE/HIO",
      Display = "HIE/HIO",
      System = "http://hl7.org/fhir/organization-role"
    };
    /// <summary>
    /// A type of non-ownership relationship between entities (encompasses partnerships, collaboration, joint ventures, etc.)
    /// </summary>
    public static readonly Coding Member = new Coding
    {
      Code = "member",
      Display = "Member",
      System = "http://hl7.org/fhir/organization-role"
    };
    /// <summary>
    /// An organization providing reimbursement, payment, or related services
    /// </summary>
    public static readonly Coding Payer = new Coding
    {
      Code = "payer",
      Display = "Payer",
      System = "http://hl7.org/fhir/organization-role"
    };
    /// <summary>
    /// Provider
    /// </summary>
    public static readonly Coding Provider = new Coding
    {
      Code = "provider",
      Display = "Provider",
      System = "http://hl7.org/fhir/organization-role"
    };
    /// <summary>
    /// An organization providing research-related services such as conducting research, recruiting research participants, analyzing data, etc.
    /// </summary>
    public static readonly Coding Research = new Coding
    {
      Code = "research",
      Display = "Research",
      System = "http://hl7.org/fhir/organization-role"
    };
    /// <summary>
    /// An organization that provides medical supplies (e.g. medical devices, equipment, pharmaceutical products, etc.)
    /// </summary>
    public static readonly Coding Supplier = new Coding
    {
      Code = "supplier",
      Display = "Supplier",
      System = "http://hl7.org/fhir/organization-role"
    };

    /// <summary>
    /// Literal for code: Agency
    /// </summary>
    public const string LiteralAgency = "agency";

    /// <summary>
    /// Literal for code: OrganizationRoleAgency
    /// </summary>
    public const string LiteralOrganizationRoleAgency = "http://hl7.org/fhir/organization-role#agency";

    /// <summary>
    /// Literal for code: Diagnostics
    /// </summary>
    public const string LiteralDiagnostics = "diagnostics";

    /// <summary>
    /// Literal for code: OrganizationRoleDiagnostics
    /// </summary>
    public const string LiteralOrganizationRoleDiagnostics = "http://hl7.org/fhir/organization-role#diagnostics";

    /// <summary>
    /// Literal for code: HIEHIO
    /// </summary>
    public const string LiteralHIEHIO = "HIE/HIO";

    /// <summary>
    /// Literal for code: OrganizationRoleHIEHIO
    /// </summary>
    public const string LiteralOrganizationRoleHIEHIO = "http://hl7.org/fhir/organization-role#HIE/HIO";

    /// <summary>
    /// Literal for code: Member
    /// </summary>
    public const string LiteralMember = "member";

    /// <summary>
    /// Literal for code: OrganizationRoleMember
    /// </summary>
    public const string LiteralOrganizationRoleMember = "http://hl7.org/fhir/organization-role#member";

    /// <summary>
    /// Literal for code: Payer
    /// </summary>
    public const string LiteralPayer = "payer";

    /// <summary>
    /// Literal for code: OrganizationRolePayer
    /// </summary>
    public const string LiteralOrganizationRolePayer = "http://hl7.org/fhir/organization-role#payer";

    /// <summary>
    /// Literal for code: Provider
    /// </summary>
    public const string LiteralProvider = "provider";

    /// <summary>
    /// Literal for code: OrganizationRoleProvider
    /// </summary>
    public const string LiteralOrganizationRoleProvider = "http://hl7.org/fhir/organization-role#provider";

    /// <summary>
    /// Literal for code: Research
    /// </summary>
    public const string LiteralResearch = "research";

    /// <summary>
    /// Literal for code: OrganizationRoleResearch
    /// </summary>
    public const string LiteralOrganizationRoleResearch = "http://hl7.org/fhir/organization-role#research";

    /// <summary>
    /// Literal for code: Supplier
    /// </summary>
    public const string LiteralSupplier = "supplier";

    /// <summary>
    /// Literal for code: OrganizationRoleSupplier
    /// </summary>
    public const string LiteralOrganizationRoleSupplier = "http://hl7.org/fhir/organization-role#supplier";

    /// <summary>
    /// Dictionary for looking up OrganizationRole Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "agency", Agency }, 
      { "http://hl7.org/fhir/organization-role#agency", Agency }, 
      { "diagnostics", Diagnostics }, 
      { "http://hl7.org/fhir/organization-role#diagnostics", Diagnostics }, 
      { "HIE/HIO", HIEHIO }, 
      { "http://hl7.org/fhir/organization-role#HIE/HIO", HIEHIO }, 
      { "member", Member }, 
      { "http://hl7.org/fhir/organization-role#member", Member }, 
      { "payer", Payer }, 
      { "http://hl7.org/fhir/organization-role#payer", Payer }, 
      { "provider", Provider }, 
      { "http://hl7.org/fhir/organization-role#provider", Provider }, 
      { "research", Research }, 
      { "http://hl7.org/fhir/organization-role#research", Research }, 
      { "supplier", Supplier }, 
      { "http://hl7.org/fhir/organization-role#supplier", Supplier }, 
    };
  };
}