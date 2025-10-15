using FluentValidation;

namespace Core.AbstractClasses;

public abstract class ValueObject<TValue>
{
  protected TValue RawValue { get; set; }
  public TValue Value { get => RawValue; set => Set(value); }
  protected abstract AbstractValidator<TValue> Schema { get; }

  public ValueObject(TValue initialValue)
  {
    RawValue = initialValue;
    Set(initialValue);
  }

  protected virtual void Set(TValue value)
  {
    var isNewValueIsValid = Schema.Validate(value).IsValid;

    if (!isNewValueIsValid)
    {
      throw new Exception();
    }

    RawValue = value;
  }

  public override string ToString()
  {
    return Value?.ToString() ?? base.ToString() ?? throw new Exception();
  }

}