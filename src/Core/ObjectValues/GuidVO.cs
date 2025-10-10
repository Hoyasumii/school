using Core.AbstractClasses;
using Core.Validators;
using FluentValidation;

namespace Core.ObjectValues;

public sealed class GuidVO(string value) : ObjectValue<string>(value)
{
  protected override AbstractValidator<string> Schema { get; } = new GuidValidator();

  public static GuidVO Make(string value)
  {
    return new(value);
  }
}