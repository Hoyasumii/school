using FluentValidation;

namespace Domain.Class.Validators;

public sealed class AcademicYearValidator : AbstractValidator<int>
{
  public AcademicYearValidator()
  {
    RuleFor(obj => obj).GreaterThanOrEqualTo(2000);
  }
}