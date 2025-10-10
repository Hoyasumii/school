using Domain.User.Enums;
using FluentValidation;

namespace Domain.User.Validators;

public class UserTypeValidator : AbstractValidator<UserType>
{
  public UserTypeValidator()
  {
    RuleFor(obj => obj).IsInEnum();
  }
}