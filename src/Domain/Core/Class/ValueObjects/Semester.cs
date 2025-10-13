using Core.AbstractClasses;
using Domain.Class.Validators;
using FluentValidation;

namespace Domain.Class.ValueObjects;

public sealed class Semester(string value) : ValueObject<string>(value)
{
  protected override AbstractValidator<string> Schema { get; } = new SemesterValidator();

  public static Semester Make(string value)
  {
    return new(value);
  }
}