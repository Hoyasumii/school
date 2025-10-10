using Core.AbstractClasses;
using Core.ObjectValues;

namespace Domain.Enrollment;

public sealed class Enrollment : Entity
{
  public required GuidVO StudentId { get; init; }
  public required GuidVO SubjectId { get; init; }
}