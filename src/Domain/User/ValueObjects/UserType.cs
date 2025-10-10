using Core.AbstractClasses;
using Domain.User.Validators;
using FluentValidation;

namespace Domain.User.ValueObjects;

public sealed class UserType(string initialValue) : ValueObject<string>(initialValue)
{
  protected override AbstractValidator<string> Schema { get; } = new UserTypeValidator();

  public static UserType Make(string initialValue)
  {
    return new(initialValue);
  }
}