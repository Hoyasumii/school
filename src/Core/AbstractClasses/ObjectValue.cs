using FluentValidation;

namespace Core.AbstractClasses;

public abstract class ObjectValue<TValue>
{
  private TValue RawValue { get; set; }
  public TValue Value { get => RawValue; set => Set(value); }
  protected abstract AbstractValidator<TValue> Schema { get; }

  public ObjectValue(TValue initialValue)
  {
    RawValue = initialValue;
    Set(initialValue);
  }

  private void Set(TValue value)
  {
    var isNewValueIsValid = Schema.Validate(value).IsValid;

    if (!isNewValueIsValid)
    {
      throw new Exception();
    }

    RawValue = value;
  }
}