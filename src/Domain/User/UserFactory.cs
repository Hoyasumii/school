using Core.Interfaces;
using Core.ObjectValues;
using Domain.User.Dtos;
using Domain.User.ObjectValues;

namespace Domain.User;

public static class UserFactory
{
  public static User Make(IHashing hashing, CreateUserDTO data)
  {
    return new User()
    {
      Email = Email.Make(data.Email),
      Password = Password.Make(hashing, data.Password),
      Address = Address.Make(data.Address),
      Name = DefinedString.Make(data.Name),
      Type = UserType.Make(data.Type)
    };
  }
}