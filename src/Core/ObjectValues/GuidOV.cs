using Core.AbstractClasses;
using Core.Validators;
using FluentValidation;

namespace Core.ObjectValues;

public sealed class GuidOV(string value) : ObjectValue<string>(value)
{
  protected override AbstractValidator<string> Schema { get; } = new GuidValidator();

  public static GuidOV Make(string value)
  {
    return new(value);
  }
}