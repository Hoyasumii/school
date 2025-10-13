using Domain.Support.UserInvite.Dtos;

namespace Domain.Support.UserInvite.Services;

public sealed class CreateUserInvite(IUserInviteRepository userInviteRepository)
{
  private readonly IUserInviteRepository UserInviteRepository = userInviteRepository;

  public async Task<UserInvite> Run(UserInviteDTO data)
  {
    if (data.Type == User.Enums.UserType.Admin) throw new Exception();
    if (data.Type == User.Enums.UserType.Director) throw new Exception();

    var newUserInvite = UserInviteFactory.Make(data);

    await UserInviteRepository.Add(newUserInvite);

    return newUserInvite;
  }
}
// TODO: Na camada de aplicação, validar se o tipo de usuário que está solicitando o convite é Admin ou se é Director