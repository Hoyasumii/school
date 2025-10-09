using Domain.User.Enums;
using FluentValidation;

namespace Domain.User.Validators;

public class UserTypeValidator : AbstractValidator<string>
{
  public UserTypeValidator()
  {
    RuleFor(obj => obj).IsEnumName(typeof(UserType));
  }
}