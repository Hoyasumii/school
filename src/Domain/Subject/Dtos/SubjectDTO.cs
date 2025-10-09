namespace Domain.Subject.Dtos;

public sealed record SubjectDTO
{
  public required string Name { get; init; }
  public required string Code { get; init; }
  public required string Description { get; init; }
  public required string TeacherId { get; init; }  
}