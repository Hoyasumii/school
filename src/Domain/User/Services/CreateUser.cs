using Core.Interfaces;
using Core.ValueObjects;
using Domain.User.Dtos;
using Domain.User.ValueObjects;

namespace Domain.User.Services;

public sealed class CreateUser(IUserRepository repository)
{
  private IUserRepository Repository { get; } = repository;

  public async Task<User> Run(IHashing hashing, UserDTO data)
  {

    var HasRegistry = await Repository.HasRegistry();
    var newUser = UserFactory.Make(hashing, data);

    if (!HasRegistry)
    {
      newUser.CreatedBy = GuidVO.Make(newUser.Id.ToString());
      newUser.Type = UserType.Make("Director");

      return newUser;
    }

    var targetCreator = await Repository.FindById(data.CreatedBy)
                        ?? throw new Exception();

    if (targetCreator.Type.Value != Enums.UserType.Director)
    {
      throw new Exception();
    }

    return newUser;
  }
}