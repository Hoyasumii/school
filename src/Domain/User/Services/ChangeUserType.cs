using Domain.User.Enums;

namespace Domain.User.Services;

public sealed class ChangeUserType(IUserRepository repository)
{
  private IUserRepository Repository { get; } = repository;

  public async Task<User[]> Run(string actorId, string targetId, UserType desiredType)
  {
    var actor = await Repository.FindById(actorId) ?? throw new Exception();
    var targetUser = await Repository.FindById(targetId) ?? throw new Exception();

    if (actor.Type.Value != UserType.Director) throw new Exception();
    if (targetUser.Type.Value == UserType.Student) throw new Exception();

    if (desiredType == UserType.Director)
      actor.Type.Value = UserType.Coordinator;

    targetUser.Type.Value = desiredType;

    return [actor, targetUser];
  }
}