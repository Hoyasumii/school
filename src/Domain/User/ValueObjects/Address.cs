using Core.AbstractClasses;
using Core.Interfaces;
using Domain.User.Dtos;
using Domain.User.Validators;
using FluentValidation;

namespace Domain.User.ValueObjects;

public sealed class Address(AddressDTO address) : ValueObject<AddressDTO>(address), IDisplayableValueObject
{
  protected override AbstractValidator<AddressDTO> Schema { get; } = new AddressValidator();

  public static Address Make(AddressDTO address)
  {
    return new(address);
  }

  public override string ToString()
  {
    return $"{Value.Street}, {Value.Number} - {Value.Neighborhood}, {Value.ZipCode} - {Value.City}, {Value.State}";
  }
}