// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Indicates the level of importance associated with reaching or sustaining a goal.
  /// </summary>
  public static class GoalPriorityCodes
  {
    /// <summary>
    /// Indicates that the goal is of considerable importance and should be a primary focus of care delivery.
    /// </summary>
    public static readonly Coding HighPriority = new Coding
    {
      Code = "high-priority",
      Display = "High Priority",
      System = "http://terminology.hl7.org/CodeSystem/goal-priority"
    };
    /// <summary>
    /// The goal is desirable but is not sufficiently important to devote significant resources to.  Achievement of the goal may be sought when incidental to achieving other goals.
    /// </summary>
    public static readonly Coding LowPriority = new Coding
    {
      Code = "low-priority",
      Display = "Low Priority",
      System = "http://terminology.hl7.org/CodeSystem/goal-priority"
    };
    /// <summary>
    /// Indicates that the goal has a reasonable degree of importance and that concrete action should be taken towards the goal.  Attainment is not as critical as high-priority goals.
    /// </summary>
    public static readonly Coding MediumPriority = new Coding
    {
      Code = "medium-priority",
      Display = "Medium Priority",
      System = "http://terminology.hl7.org/CodeSystem/goal-priority"
    };
  };
}
