using Core.AbstractClasses;
using Core.ValueObjects;
using Domain.Support.User.ValueObjects;

namespace Domain.Support.UserInvite;

public sealed class UserInvite(string? id, DateTime? createdAt) : Entity(id, createdAt)
{
  public required GuidVO InvitedBy { get; init; }
  public required UserType Type { get; init; }
}
