using Core.AbstractClasses;
using Domain.User.Enums;
using Domain.User.ObjectValues;

namespace Domain.User;

public sealed class User : Entity
{
  public required string Name { get; init; }
  public required Email Email { get; init; }
  public required string Password { get; init; }
  public UserTypes Type { get; init; } = UserTypes.Student;
}