using Core.AbstractClasses;
using Domain.User.Validators;
using FluentValidation;

namespace Domain.User.ObjectValues;

public sealed class Password(string password) : ObjectValue<string>(password)
{
  protected override AbstractValidator<string> Schema { get; } = new PasswordValidator();

  public static Password Make(string password)
  {
    return new(password);
  }
}