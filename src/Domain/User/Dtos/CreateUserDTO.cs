namespace Domain.User.Dtos;

public sealed record CreateUserDTO
{
  public required string Name { get; init; }
  public required string Email { get; init; }
  public required string Password { get; init; }
  public required string Type { get; init; }
  public required AddressDTO Address { get; init; }
}