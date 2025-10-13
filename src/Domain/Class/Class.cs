using Core.AbstractClasses;
using Core.ValueObjects;
using Domain.Class.ValueObjects;

namespace Domain.Class;

public sealed class Class(string? id, DateTime? createdAt) : Entity(id, createdAt)
{
  // TODO: Verificar se existe
  public required GuidVO CreatedBy { get; init; }
  // TODO: Verificar se existe
  public required GuidVO SubjectId { get; init; }
  // TODO: Verificar se existe
  public required GuidVO TeacherId { get; init; }
  public required DefinedString Name { get; init; }
  public required AcademicYear AcademicYear { get; init; }
  public required Semester Semester { get; init; }
  public bool Active { get; set; } = true;

  // TODO: Permitir a alteração
  // TODO: Caso um 
}