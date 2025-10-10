using Core.Interfaces;
using Core.ObjectValues;
using Domain.User.Dtos;
using Domain.User.ObjectValues;

namespace Domain.User;

public static class UserFactory
{
  public static User Make(IHashing hashing, UserDTO data, string? id, DateTime? createdAt)
  {
    return new User(id, createdAt)
    {
      Email = Email.Make(data.Email),
      Password = Password.Make(hashing, data.Password),
      Address = Address.Make(data.Address),
      Name = Name.Make(data.Name),
      BirthDate = data.BirthDate,
      CreatedBy = GuidVO.Make(data.CreatedBy),
      Type = UserType.Make(data.Type)
    };
  }
}