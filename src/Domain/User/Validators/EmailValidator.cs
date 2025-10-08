using FluentValidation;

namespace Domain.User.Validators;

public sealed class EmailValidator : AbstractValidator<string>
{
  public EmailValidator()
  {
    RuleFor(obj => obj).EmailAddress();
  }
}