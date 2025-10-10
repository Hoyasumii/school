using Core.AbstractClasses;
using Core.Interfaces;
using Domain.User.Dtos;
using Domain.User.Validators;
using FluentValidation;

namespace Domain.User.ObjectValues;

public sealed class Name(NameDTO name) : ObjectValue<NameDTO>(name), IDisplayableObjectValue
{
  protected override AbstractValidator<NameDTO> Schema { get; } = new NameValidator();

  public static Name Make(NameDTO name)
  {
    return new(name);
  }

  public override string ToString()
  {
    return $"{Value.FirstName} {Value.LastName}";
  }
}