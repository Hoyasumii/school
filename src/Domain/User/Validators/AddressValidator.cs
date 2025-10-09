using Domain.User.Dtos;
using FluentValidation;

namespace Domain.User.Validators;

internal sealed class AddressValidator : AbstractValidator<AddressDTO>
{
  public AddressValidator()
  {
    RuleFor(address => address.ZipCode).MinimumLength(3);
    RuleFor(address => address.State).MinimumLength(3);
    RuleFor(address => address.City).MinimumLength(3);
    RuleFor(address => address.Neighborhood).MinimumLength(3);
    RuleFor(address => address.Street).MinimumLength(3);
  }
}