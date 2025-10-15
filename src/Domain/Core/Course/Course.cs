using Core.AbstractClasses;
using Core.ValueObjects;

namespace Domain.Core.Course;

public sealed class Course(string? id, DateTime? createdAt) : Entity(id, createdAt)
{
  public required GuidVO CoordinatorId { get; init; }
  public required DefinedString Name { get; init; }
}

