using Domain.Support.User.Enums;

namespace Domain.Support.User.Dtos;

public record UserDTO
{
  public required NameDTO Name { get; init; }
  public required DateTime BirthDate { get; init; }
  
  public required string Email { get; init; }
  public required string Password { get; init; }
  public required UserType Type { get; init; }
  public required AddressDTO Address { get; init; }
}