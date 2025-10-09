using Core.AbstractClasses;
using Domain.User.Dtos;
using Domain.User.Validators;
using FluentValidation;

namespace Domain.User.ObjectValues;

public sealed class Address(AddressDTO address) : ObjectValue<AddressDTO>(address)
{
  protected override AbstractValidator<AddressDTO> Schema { get; } = new AddressValidator();

  public static Address Make(AddressDTO address)
  {
    return new(address);
  }
}