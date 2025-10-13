using Core.AbstractClasses;
using Domain.Support.User.Validators;
using FluentValidation;

namespace Domain.Support.User.ValueObjects;

public sealed class Email(string email) : ValueObject<string>(email)
{
  protected override AbstractValidator<string> Schema { get; } = new EmailValidator();

  public static Email Make(string email)
  {
    return new(email);
  }
}