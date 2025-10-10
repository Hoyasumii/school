namespace Domain.Class.Dtos;

public sealed record ClassDTO
{
  public required string CreatedBy { get; init; }
  public required string SubjectId { get; init; }
  public required string TeacherId { get; init; }
  public required string Name { get; init; }
  public required int AcademicYear { get; init; }
  public required string Semester { get; init; }
  public required bool Active { get; init; } = true;
}