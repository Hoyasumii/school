using Core.Interfaces;
using Domain.Support.User.Dtos;
using Domain.Support.User.ValueObjects;

namespace Domain.Support.User.Services;

public sealed class ChangeUserDataDomainService(IUserRepository repository)
{
  private IUserRepository Repository { get; } = repository;

  public async Task<User> Run(IHashing hashing, User user, UpdateUserDTO data)
  {
    if (data.Address is not null)
      user.Address = Address.Make(data.Address);

    if (data.Email is not null)
    {
      var emailExists = await Repository.EmailExists(data.Email);

      if (emailExists) throw new Exception();

      user.Email = Email.Make(data.Email);
    }

    if (data.Password is not null)
      user.Password = Password.Make(hashing, data.Password);

    return user;
  } 
}