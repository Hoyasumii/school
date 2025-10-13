using Core.AbstractClasses;
using Domain.Class.Validators;
using FluentValidation;

namespace Domain.Class.ValueObjects;

public sealed class AcademicYear(int initialValue) : ValueObject<int>(initialValue)
{
  protected override AbstractValidator<int> Schema { get; } = new AcademicYearValidator();

  public static AcademicYear Make(int value)
  {
    return new(value);
  }
}