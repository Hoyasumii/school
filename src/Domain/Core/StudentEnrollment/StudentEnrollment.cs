using Core.AbstractClasses;
using Core.ValueObjects;

namespace Domain.StudentEnrollment;

public sealed class StudentEnrollment(string? id, DateTime createdAt) : Entity(id, createdAt)
{
  public required GuidVO CreatedBy { get; init; }
  public required GuidVO StudentId { get; init; }
  public required GuidVO ClassId { get; init; }
}