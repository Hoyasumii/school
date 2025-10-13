namespace Domain.Support.User.Dtos;

public sealed record CreateUserDTO : UserDTO
{
  public required string InvitedBy { get; init; }
}