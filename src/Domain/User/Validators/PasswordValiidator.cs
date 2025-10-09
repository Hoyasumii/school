using FluentValidation;

namespace Domain.User.Validators;

internal sealed class PasswordValidator : AbstractValidator<string>
{
  public PasswordValidator()
  {
    RuleFor(obj => obj)
    .MinimumLength(7)
    .Matches("[a-z]")
    .Matches("[A-Z]")
    .Matches("[0-9]")
    .Matches("[^a-zA-Z0-9]");
  }
}