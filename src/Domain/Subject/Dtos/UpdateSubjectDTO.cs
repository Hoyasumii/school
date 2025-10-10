namespace Domain.Subject.Dtos;

public sealed record UpdateSubjectDTO
{
  public required string Name { get; init; }
  public required string Description { get; init; }
}