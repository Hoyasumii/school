using Domain.Support.User.Enums;

namespace Domain.Support.User.Services.Interfaces;

public interface IUserRemovalValidator
{
  public UserType UserType { get; }
  public Task Validate(User user);
}
