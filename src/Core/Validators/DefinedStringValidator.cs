using FluentValidation;

namespace Core.Validators;

public sealed class DefinedStringValidator : AbstractValidator<string>
{
  public DefinedStringValidator()
  {
    RuleFor(obj => obj).NotEmpty();
  }
}