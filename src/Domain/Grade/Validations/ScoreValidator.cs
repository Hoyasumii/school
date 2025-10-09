using FluentValidation;

namespace Domain.Grade.Validations;

public sealed class ScoreValidator : AbstractValidator<double>
{
  public ScoreValidator()
  {
    RuleFor(obj => obj)
    .GreaterThanOrEqualTo(0)
    .LessThanOrEqualTo(10);
  }
}