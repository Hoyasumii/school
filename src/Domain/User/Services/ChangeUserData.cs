using Core.Interfaces;
using Domain.User.Dtos;
using Domain.User.ValueObjects;

namespace Domain.User.Services;

public sealed class ChangeUserData(IUserRepository repository)
{
  private IUserRepository Repository { get; } = repository;

  public async Task<User> Run(IHashing hashing, string userId, UpdateUserDTO data)
  {
    var targetUser = await Repository.FindById(userId) ?? throw new Exception();

    if (data.Address is not null)
      targetUser.Address = Address.Make(data.Address);

    if (data.Email is not null)
    {
      var emailExists = await Repository.EmailExists(data.Email);

      if (emailExists) throw new Exception();

      targetUser.Email = Email.Make(data.Email);
    }

    if (data.Password is not null)
      targetUser.Password = Password.Make(hashing, data.Password);

    return targetUser;
  } 
}