namespace Domain.User.Dtos;

public sealed record NameDTO
{
  public required string FirstName { get; init; }
  public required string LastName { get; init; }
}