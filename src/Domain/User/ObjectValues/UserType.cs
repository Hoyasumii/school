using Core.AbstractClasses;
using Domain.User.Validators;
using FluentValidation;

namespace Domain.User.ObjectValues;

public sealed class UserType(string initialValue) : ObjectValue<string>(initialValue)
{
  protected override AbstractValidator<string> Schema { get; } = new UserTypeValidator();

  public static UserType Make(string initialValue)
  {
    return new(initialValue);
  }
}