namespace Domain.User.Dtos;

public sealed record UserDTO
{
  public required NameDTO Name { get; init; }
  public required string CreatedBy { get; init; }
  public required DateTime BirthDate { get; init; }
  
  public required string Email { get; init; }
  public required string Password { get; init; }
  public required string Type { get; init; }
  public required AddressDTO Address { get; init; }
}