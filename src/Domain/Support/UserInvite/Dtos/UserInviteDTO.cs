using Domain.Support.User.Enums;

namespace Domain.Support.UserInvite.Dtos;

public sealed record UserInviteDTO
{
  public required string InvitedBy { get; init; }
  public required UserType Type { get; init; } = UserType.Student;
}