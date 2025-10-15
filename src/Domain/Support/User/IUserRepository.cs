using Domain.Support.User.Enums;

namespace Domain.Support.User;

public interface IUserRepository
{
  public Task Add(User content);
  public Task<User?> FindById(string targetId);
  public Task<User?> FindByEmail(string targetEmail);
  public Task<List<User>> FindByType(UserType type);
  public Task<bool> Remove(User user);
  public Task<bool> EmailExists(string email);
  public Task<bool> HasAdmin();
  public Task<bool> HasDirector();
}