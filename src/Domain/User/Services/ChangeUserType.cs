using Domain.User.Enums;

namespace Domain.User.Services;

public sealed class ChangeUserType(IUserRepository repository)
{
  private IUserRepository Repository { get; } = repository;

  public async Task<User[]> Run(User actor, string targetId, UserType desiredType)
  {
    var targetUser = await Repository.FindById(targetId) ?? throw new Exception();

    if (desiredType == UserType.Director)
      actor.Type.Value = UserType.Coordinator;

    targetUser.Type.Value = desiredType;

    return [actor, targetUser];
  }
}

// TODO Na camada de aplicação, adicionar a validação de roles:
/* 
actor.Type != Director -> Não Autorizado
target.Type == Student -> Não Permitido
target.Type == Teacher && desiredType == Student -> Não Autorizado
 */