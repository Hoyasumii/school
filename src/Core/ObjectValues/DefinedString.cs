using Core.AbstractClasses;
using Core.Validators;
using FluentValidation;

namespace Core.ObjectValues;

public sealed class DefinedString(string value) : ObjectValue<string>(value)
{
  protected override AbstractValidator<string> Schema { get; } = new DefinedStringValidator();

  public static DefinedString Make(string value)
  {
    return new(value);
  }
}