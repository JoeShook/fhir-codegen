// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// More detailed code concerning the type of the audit event - defined by DICOM with some FHIR specific additions.
  /// </summary>
  public static class AuditEventSubTypeCodes
  {
    /// <summary>
    /// Audit event: Application Entity has started
    /// </summary>
    public static readonly Coding ApplicationStart_dicom_dcim = new Coding
    {
      Code = "110120",
      Display = "Application Start",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Application Entity has stopped
    /// </summary>
    public static readonly Coding ApplicationStop_dicom_dcim = new Coding
    {
      Code = "110121",
      Display = "Application Stop",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: User login has been attempted
    /// </summary>
    public static readonly Coding Login_dicom_dcim = new Coding
    {
      Code = "110122",
      Display = "Login",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: User logout has been attempted
    /// </summary>
    public static readonly Coding Logout_dicom_dcim = new Coding
    {
      Code = "110123",
      Display = "Logout",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Node has been attached
    /// </summary>
    public static readonly Coding Attach_dicom_dcim = new Coding
    {
      Code = "110124",
      Display = "Attach",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Node has been detached
    /// </summary>
    public static readonly Coding Detach_dicom_dcim = new Coding
    {
      Code = "110125",
      Display = "Detach",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Node Authentication has been attempted
    /// </summary>
    public static readonly Coding NodeAuthentication_dicom_dcim = new Coding
    {
      Code = "110126",
      Display = "Node Authentication",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Emergency Override has started
    /// </summary>
    public static readonly Coding EmergencyOverrideStarted_dicom_dcim = new Coding
    {
      Code = "110127",
      Display = "Emergency Override Started",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Network configuration has been changed
    /// </summary>
    public static readonly Coding NetworkConfiguration_dicom_dcim = new Coding
    {
      Code = "110128",
      Display = "Network Configuration",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Security configuration has been changed
    /// </summary>
    public static readonly Coding SecurityConfiguration_dicom_dcim = new Coding
    {
      Code = "110129",
      Display = "Security Configuration",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Hardware configuration has been changed
    /// </summary>
    public static readonly Coding HardwareConfiguration_dicom_dcim = new Coding
    {
      Code = "110130",
      Display = "Hardware Configuration",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Software configuration has been changed
    /// </summary>
    public static readonly Coding SoftwareConfiguration_dicom_dcim = new Coding
    {
      Code = "110131",
      Display = "Software Configuration",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: A use of a restricted function has been attempted
    /// </summary>
    public static readonly Coding UseOfRestrictedFunction_dicom_dcim = new Coding
    {
      Code = "110132",
      Display = "Use of Restricted Function",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Audit recording has been stopped
    /// </summary>
    public static readonly Coding AuditRecordingStopped_dicom_dcim = new Coding
    {
      Code = "110133",
      Display = "Audit Recording Stopped",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Audit recording has been started
    /// </summary>
    public static readonly Coding AuditRecordingStarted_dicom_dcim = new Coding
    {
      Code = "110134",
      Display = "Audit Recording Started",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Security attributes of an object have been changed
    /// </summary>
    public static readonly Coding ObjectSecurityAttributesChanged_dicom_dcim = new Coding
    {
      Code = "110135",
      Display = "Object Security Attributes Changed",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Security roles have been changed
    /// </summary>
    public static readonly Coding SecurityRolesChanged_dicom_dcim = new Coding
    {
      Code = "110136",
      Display = "Security Roles Changed",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Security attributes of a user have been changed
    /// </summary>
    public static readonly Coding UserSecurityAttributesChanged_dicom_dcim = new Coding
    {
      Code = "110137",
      Display = "User security Attributes Changed",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Emergency Override has Stopped
    /// </summary>
    public static readonly Coding EmergencyOverrideStopped_dicom_dcim = new Coding
    {
      Code = "110138",
      Display = "Emergency Override Stopped",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Remote Service Operation has Begun
    /// </summary>
    public static readonly Coding RemoteServiceOperationStarted_dicom_dcim = new Coding
    {
      Code = "110139",
      Display = "Remote Service Operation Started",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Remote Service Operation has Stopped
    /// </summary>
    public static readonly Coding RemoteServiceOperationStopped_dicom_dcim = new Coding
    {
      Code = "110140",
      Display = "Remote Service Operation Stopped",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Local Service Operation has Begun
    /// </summary>
    public static readonly Coding LocalServiceOperationStarted_dicom_dcim = new Coding
    {
      Code = "110141",
      Display = "Local Service Operation Started",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Local Service Operation Stopped
    /// </summary>
    public static readonly Coding LocalServiceOperationStopped_dicom_dcim = new Coding
    {
      Code = "110142",
      Display = "Local Service Operation Stopped",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// perform a set of a separate interactions in a single http operation
    /// </summary>
    public static readonly Coding Batch_restful_interaction = new Coding
    {
      Code = "batch",
      Display = "batch",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Get a Capability Statement for the system.
    /// </summary>
    public static readonly Coding Capabilities_restful_interaction = new Coding
    {
      Code = "capabilities",
      Display = "capabilities",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Create a new resource with a server assigned id.
    /// </summary>
    public static readonly Coding Create_restful_interaction = new Coding
    {
      Code = "create",
      Display = "create",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Delete a resource.
    /// </summary>
    public static readonly Coding Delete_restful_interaction = new Coding
    {
      Code = "delete",
      Display = "delete",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Retrieve the change history for a particular resource, type of resource, or the entire system.
    /// </summary>
    public static readonly Coding History_restful_interaction = new Coding
    {
      Code = "history",
      Display = "history",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Retrieve the change history for a particular resource.
    /// </summary>
    public static readonly Coding HistoryInstance_restful_interaction = new Coding
    {
      Code = "history-instance",
      Display = "history-instance",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Retrieve the change history for all resources on a system.
    /// </summary>
    public static readonly Coding HistorySystem_restful_interaction = new Coding
    {
      Code = "history-system",
      Display = "history-system",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Retrieve the change history for all resources of a particular type.
    /// </summary>
    public static readonly Coding HistoryType_restful_interaction = new Coding
    {
      Code = "history-type",
      Display = "history-type",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Perform an operation as defined by an OperationDefinition.
    /// </summary>
    public static readonly Coding Operation_restful_interaction = new Coding
    {
      Code = "operation",
      Display = "operation",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Update an existing resource by posting a set of changes to it.
    /// </summary>
    public static readonly Coding Patch_restful_interaction = new Coding
    {
      Code = "patch",
      Display = "patch",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Read the current state of the resource.
    /// </summary>
    public static readonly Coding Read_restful_interaction = new Coding
    {
      Code = "read",
      Display = "read",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Search a resource type or all resources based on some filter criteria.
    /// </summary>
    public static readonly Coding Search_restful_interaction = new Coding
    {
      Code = "search",
      Display = "search",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Search all resources based on some filter criteria.
    /// </summary>
    public static readonly Coding SearchSystem_restful_interaction = new Coding
    {
      Code = "search-system",
      Display = "search-system",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Search all resources of the specified type based on some filter criteria.
    /// </summary>
    public static readonly Coding SearchType_restful_interaction = new Coding
    {
      Code = "search-type",
      Display = "search-type",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Update, create or delete a set of resources as a single transaction.
    /// </summary>
    public static readonly Coding Transaction_restful_interaction = new Coding
    {
      Code = "transaction",
      Display = "transaction",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Update an existing resource by its id (or create it if it is new).
    /// </summary>
    public static readonly Coding Update_restful_interaction = new Coding
    {
      Code = "update",
      Display = "update",
      System = "http://hl7.org/fhir/restful-interaction"
    };
    /// <summary>
    /// Read the state of a specific version of the resource.
    /// </summary>
    public static readonly Coding Vread_restful_interaction = new Coding
    {
      Code = "vread",
      Display = "vread",
      System = "http://hl7.org/fhir/restful-interaction"
    };
  };
}
