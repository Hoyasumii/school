using Core.AbstractClasses;
using Core.ValueObjects;

namespace Domain.Core.Subject;

public sealed class Subject(string? id, DateTime? createdAt) : Entity(id, createdAt)
{
  public required DefinedString Name { get; set; }
  public required DefinedString Description { get; set; }
  public required GuidVO CourseId { get; set; }
  public bool Active { get; set; } 
}