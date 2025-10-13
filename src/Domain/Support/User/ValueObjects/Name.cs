using Core.AbstractClasses;
using Core.Interfaces;
using Domain.Support.User.Dtos;
using Domain.Support.User.Validators;
using FluentValidation;

namespace Domain.Support.User.ValueObjects;

public sealed class Name(NameDTO name) : ValueObject<NameDTO>(name), IDisplayableValueObject
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