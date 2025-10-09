using Core.AbstractClasses;
using Core.ObjectValues;

namespace Domain.Subject;

public sealed class Subject : Entity
{
  public required DefinedString Name { get; init; }
  public required DefinedString Code { get; init; }
  public required DefinedString Description { get; init; }
  public required GuidOV TeacherId { get; init; }
}