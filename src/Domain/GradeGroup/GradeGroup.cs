using Core.AbstractClasses;
using Core.ObjectValues;

namespace Domain.GradeGroup;

public sealed class GradeGroup : Entity
{
  public required GuidVO SubjectId { get; init; }
  public required DefinedString Name { get; init; }
}