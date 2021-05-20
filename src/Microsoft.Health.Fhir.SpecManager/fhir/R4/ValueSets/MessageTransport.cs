// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The protocol used for message transport.
  /// </summary>
  public static class MessageTransportCodes
  {
    /// <summary>
    /// The application sends or receives messages using File Transfer Protocol.
    /// </summary>
    public static readonly Coding FTP = new Coding
    {
      Code = "ftp",
      Display = "FTP",
      System = "http://terminology.hl7.org/CodeSystem/message-transport"
    };
    /// <summary>
    /// The application sends or receives messages using HTTP POST (may be over http: or https:).
    /// </summary>
    public static readonly Coding HTTP = new Coding
    {
      Code = "http",
      Display = "HTTP",
      System = "http://terminology.hl7.org/CodeSystem/message-transport"
    };
    /// <summary>
    /// The application sends or receives messages using HL7's Minimal Lower Level Protocol.
    /// </summary>
    public static readonly Coding MLLP = new Coding
    {
      Code = "mllp",
      Display = "MLLP",
      System = "http://terminology.hl7.org/CodeSystem/message-transport"
    };
  };
}
