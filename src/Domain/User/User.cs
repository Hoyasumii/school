using Core.AbstractClasses;
using Core.ObjectValues;
using Domain.User.ObjectValues;

namespace Domain.User;

public sealed class User : Entity
{
  public required DefinedString Name { get; init; }
  public required Email Email { get; init; }
  public required Password Password { get; init; }
  public required UserType Type { get; init; }
  public required Address Address { get; init; }
}

