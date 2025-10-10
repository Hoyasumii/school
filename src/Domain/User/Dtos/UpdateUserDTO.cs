namespace Domain.User.Dtos;

public sealed record UpdateUserDTO
{
  public string? Email { get; init; }
  public string? Password { get; init; }
  public AddressDTO? Address { get; init; }
}