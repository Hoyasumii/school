namespace Domain.Core.Course.Dtos;

public sealed record UpdateCourseDTO
{
  public string? Name { get; init; }
  public string? CoordinatorId { get; init; }
}
