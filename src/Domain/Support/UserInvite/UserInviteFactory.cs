using Core.ValueObjects;
using Domain.Support.User.ValueObjects;
using Domain.Support.UserInvite.Dtos;

namespace Domain.Support.UserInvite;

public static class UserInviteFactory
{
  public static UserInvite Make(UserInviteDTO data, string? id = null, DateTime? createdAt = null)
  {
    return new(id, createdAt)
    {
      InvitedBy = GuidVO.Make(data.InvitedBy),
      Type = UserType.Make(data.Type.ToString())
    };
  }
}