using Core.Interfaces;
using Domain.Support.User.Dtos;
using Domain.Support.User.ValueObjects;

namespace Domain.Support.User.Services;

public sealed class CreateUserDomainService(IUserRepository userRepository)
{
  private readonly IUserRepository UserRepository = userRepository;

  public async Task<User> Run(IHashing hashing, UserDTO data)
  {
    var HasDirector = await UserRepository.HasDirector();
    var newUser = UserFactory.Make(hashing, data);

    if (!HasDirector)
    {
      newUser.Type = UserType.Make("Director");
    }

    return newUser;
  }
}