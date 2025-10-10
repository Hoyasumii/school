using Domain.User.Dtos;
using Domain.User.Enums;

namespace Domain.User;

public interface IUserRepository
{
  public Task<User> Add(User content);
  public Task<User?> FindById(string targetId);
  public Task<User?> FindByEmail(string targetEmail);
  public Task<List<User>> FindByType(UserType type);
  public Task<User?> Remove(string userId);
  public Task<bool> EmailExists(string email);
  public Task<bool> HasRegistry();
}