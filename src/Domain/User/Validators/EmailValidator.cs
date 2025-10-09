using FluentValidation;

namespace Domain.User.Validators;

internal sealed class EmailValidator : AbstractValidator<string>
{
  public EmailValidator()
  {
    RuleFor(obj => obj).EmailAddress();
  }
}