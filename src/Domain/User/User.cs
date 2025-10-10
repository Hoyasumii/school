using Core.AbstractClasses;
using Core.ObjectValues;
using Domain.User.ObjectValues;

namespace Domain.User;

public sealed class User(string? id = null, DateTime? createdAt = null) : Entity(id, createdAt)
{
  public required Name Name { get; init; }
  public required GuidOV CreatedBy { get; init; }
  public required DateTime BirthDate { get; init; }
  public required Email Email { get; init; }
  public required Password Password { get; init; }
  public required UserType Type { get; init; }
  public required Address Address { get; init; }
}
