using FluentValidation;

namespace Domain.Support.User.Validators;

internal sealed class EmailValidator : AbstractValidator<string>
{
  public EmailValidator()
  {
    RuleFor(obj => obj).EmailAddress();
  }
}