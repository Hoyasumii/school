using Core.AbstractClasses;
using Core.ObjectValues;

namespace Domain.GradeGroup;

public sealed class GradeGroup : Entity
{
  public required GuidOV SubjectId { get; init; }
  public required DefinedString Name { get; init; }
}