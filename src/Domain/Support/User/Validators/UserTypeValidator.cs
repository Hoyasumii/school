using Domain.Support.User.Enums;
using FluentValidation;

namespace Domain.Support.User.Validators;

public class UserTypeValidator : AbstractValidator<UserType>
{
  public UserTypeValidator()
  {
    RuleFor(obj => obj).IsInEnum();
  }
}