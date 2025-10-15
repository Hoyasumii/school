using Domain.Support.User.Enums;

namespace Domain.Support.User.Services;

public sealed class ChangeUserTypeDomainService
{
  public static User[] Run(User actor, User user, UserType desiredType)
  {
    if (desiredType == UserType.Director)
      actor.Type.Value = UserType.Coordinator;

    user.Type.Value = desiredType;

    return [actor, user];
  }
}

// TODO Na camada de aplicação, adicionar a validação de roles:
/* 
actor.Type != Director -> Não Autorizado
target.Type == Student -> Não Permitido
target.Type == Teacher && desiredType == Student -> Não Autorizado
 */