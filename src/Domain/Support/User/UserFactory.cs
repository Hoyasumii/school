using Core.Interfaces;
using Domain.Support.User.Dtos;
using Domain.Support.User.ValueObjects;

namespace Domain.Support.User;

public static class UserFactory
{
  public static User Make(IHashing hashing, UserDTO data, string? id = null, DateTime? createdAt = null)
  {
    var user = new User(id, createdAt)
    {
      Email = Email.Make(data.Email),
      Password = Password.Make(hashing, data.Password),
      Address = Address.Make(data.Address),
      Name = Name.Make(data.Name),
      BirthDate = data.BirthDate,
      Type = UserType.Make(data.Type.ToString())
    };

    // user.AddEvent()

    return user;
  }
}