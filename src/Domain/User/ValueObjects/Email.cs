using Core.AbstractClasses;
using Domain.User.Validators;
using FluentValidation;

namespace Domain.User.ValueObjects;

public sealed class Email(string email) : ValueObject<string>(email)
{
  protected override AbstractValidator<string> Schema { get; } = new EmailValidator();

  public static Email Make(string email)
  {
    return new(email);
  }
}