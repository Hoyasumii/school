namespace Domain.Core.Subject.Dtos;

public sealed record SubjectDTO
{
  public required string Name { get; init; }
  public required string Description { get; init; }
  public required string CourseId { get; init; }
  public required bool Active { get; init; }
}