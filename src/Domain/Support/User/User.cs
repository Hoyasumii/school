using Core.AbstractClasses;
using Domain.Support.User.ValueObjects;

namespace Domain.Support.User;

public sealed class User(string? id, DateTime? createdAt) : Entity(id, createdAt)
{
  public required Name Name { get; set; }
  public required DateTime BirthDate { get; init; }
  public required Email Email { get; set; }
  public required Password Password { get; set; }
  public required UserType Type { get; set; }
  public required Address Address { get; set; }
}
