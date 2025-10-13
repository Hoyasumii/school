using Core.AbstractClasses;
using Domain.Support.User.Validators;
using FluentValidation;

namespace Domain.Support.User.ValueObjects;

public sealed class UserType(Enums.UserType initialValue) : ValueObject<Enums.UserType>(initialValue)
{
  protected override AbstractValidator<Enums.UserType> Schema { get; } = new UserTypeValidator();

  public static UserType Make(string initialValue)
  {
    var userTypeIsValid = Enum.TryParse(initialValue, out Enums.UserType userType);

    if (!userTypeIsValid) throw new Exception();

    return new(userType);
  }
}