namespace Domain.Core.Subject.Dtos;

public sealed record UpdateSubjectDTO
{
  public string? Name { get; init; }
  public string? Description { get; init; }
}