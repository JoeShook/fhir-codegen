// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The quality rating of the subcomponent of a quality of evidence rating.
  /// </summary>
  public static class CertaintySubcomponentRatingCodes
  {
    /// <summary>
    /// possible reason for increasing quality rating was checked and found to be absent.
    /// </summary>
    public static readonly Coding Absent = new Coding
    {
      Code = "absent",
      Display = "absent",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// critical concern.
    /// </summary>
    public static readonly Coding CriticalConcern = new Coding
    {
      Code = "critical-concern",
      Display = "critical concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// reduce quality rating by 1.
    /// </summary>
    public static readonly Coding ReduceRating1 = new Coding
    {
      Code = "downcode1",
      Display = "reduce rating: -1",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// reduce quality rating by 2.
    /// </summary>
    public static readonly Coding ReduceRating2 = new Coding
    {
      Code = "downcode2",
      Display = "reduce rating: -2",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// reduce quality rating by 3.
    /// </summary>
    public static readonly Coding ReduceRating3 = new Coding
    {
      Code = "downcode3",
      Display = "reduce rating: -3",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// no change to quality rating.
    /// </summary>
    public static readonly Coding NoChangeToRating = new Coding
    {
      Code = "no-change",
      Display = "no change to rating",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// no serious concern.
    /// </summary>
    public static readonly Coding NoSeriousConcern = new Coding
    {
      Code = "no-concern",
      Display = "no serious concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// possible reason for increasing quality rating was checked and found to bepresent.
    /// </summary>
    public static readonly Coding Present = new Coding
    {
      Code = "present",
      Display = "present",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// serious concern.
    /// </summary>
    public static readonly Coding SeriousConcern = new Coding
    {
      Code = "serious-concern",
      Display = "serious concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// increase quality rating by 1.
    /// </summary>
    public static readonly Coding IncreaseRatingPlus1 = new Coding
    {
      Code = "upcode1",
      Display = "increase rating: +1",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// increase quality rating by 2.
    /// </summary>
    public static readonly Coding IncreaseRatingPlus2 = new Coding
    {
      Code = "upcode2",
      Display = "increase rating: +2",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
  };
}
