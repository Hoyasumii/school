using Core.AbstractClasses;
using Core.ObjectValues;

namespace Domain.Subject;

public sealed class Subject(string? id, DateTime? createdAt) : Entity(id, createdAt)
{
  public required DefinedString Name { get; init; }
  public required DefinedString Description { get; init; }
  public required GuidVO CreatedBy { get; init; }
}