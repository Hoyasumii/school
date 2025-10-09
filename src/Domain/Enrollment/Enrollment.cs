using Core.AbstractClasses;
using Core.ObjectValues;

namespace Domain.Enrollment;

public sealed class Enrollment : Entity
{
  public required GuidOV StudentId { get; init; }
  public required GuidOV SubjectId { get; init; }
}