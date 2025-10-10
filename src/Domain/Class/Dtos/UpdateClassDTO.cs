namespace Domain.Class.Dtos;

public sealed record UpdateClassDTO
{
  public string? TeacherId { get; init; }
  public string? Name { get; init; }
  public int? AcademicYear { get; init; }
  public string? Semester { get; init; }
  public bool? Active { get; init; }
}