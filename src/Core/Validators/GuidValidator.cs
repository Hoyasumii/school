using FluentValidation;

namespace Core.Validators;

public sealed class GuidValidator : AbstractValidator<string>
{
  public GuidValidator()
  {
    RuleFor(obj => obj)
    .NotEmpty()
    .Must(id => Guid.TryParse(id, out _));
  }
}