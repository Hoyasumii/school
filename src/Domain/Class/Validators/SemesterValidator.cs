using Domain.Class.Enums;
using FluentValidation;

namespace Domain.Class.Validators;

public sealed class SemesterValidator : AbstractValidator<string>
{
  public SemesterValidator()
  {
    RuleFor(obj => obj).IsEnumName(typeof(Semester));
  }
}