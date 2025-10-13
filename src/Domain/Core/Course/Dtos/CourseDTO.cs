namespace Domain.Course.Dtos;

public sealed record CourseDTO
{
  public required string Name { get; init; }
  public required string CoordinatorId { get; init; }
}