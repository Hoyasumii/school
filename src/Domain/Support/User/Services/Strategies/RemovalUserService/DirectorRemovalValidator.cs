using Domain.Support.User.Enums;
using Domain.Support.User.Services.Interfaces;

namespace Domain.Support.User.Services.Strategies.RemovalUserService;

public sealed class DirectorRemovalValidator : IUserRemovalValidator
{
  public UserType UserType { get; } = UserType.Director;

  public Task Validate(User user)
  {
    throw new Exception();
  }
}
