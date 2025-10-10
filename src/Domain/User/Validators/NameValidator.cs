using Core.Validators;
using Domain.User.Dtos;
using FluentValidation;

namespace Domain.User.Validators;

public sealed class NameValidator : AbstractValidator<NameDTO>
{
  public NameValidator()
  {
    RuleFor(obj => obj.FirstName)
    .SetValidator(new DefinedStringValidator())
    .MinimumLength(3);

    RuleFor(obj => obj.LastName)
    .SetValidator(new DefinedStringValidator())
    .MinimumLength(3);
  }
}