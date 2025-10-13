using Core.Interfaces;
using Core.ValueObjects;
using Domain.Support.User.Dtos;
using Domain.Support.User.ValueObjects;
using Domain.Support.UserInvite;

namespace Domain.Support.User.Services;

public sealed class CreateUserService(IUserRepository userRepository, IUserInviteRepository userInviteRepository)
{
  private readonly IUserInviteRepository UserInvirteRepository = userInviteRepository;
  private readonly IUserRepository UserRepository = userRepository;

  public async Task<User> Run(IHashing hashing, CreateUserDTO data)
  {

    var invitingUser = await UserRepository.FindById(data.InvitedBy) 
                        ?? throw new Exception();

    if (invitingUser.Type.Value != Enums.UserType.Admin &&
      invitingUser.Type.Value != Enums.UserType.Director) 
      throw new Exception();

    var HasDirector = await UserRepository.HasDirector();
    var newUser = UserFactory.Make(hashing, data);

    if (!HasDirector)
    {
      newUser.Type = UserType.Make("Director");

      return newUser;
    }



    return newUser;
  }
}