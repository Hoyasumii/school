namespace Domain.User.Dtos;

public sealed record UpdateUserDTO
{
  public required string Email { get; init; }
  public required string Password { get; init; }
  public required AddressDTO Address { get; init; }
}