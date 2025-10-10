using Domain.User.Dtos;
using Domain.User.Enums;

namespace Domain.User;

public interface IUserRepository
{
  public Task<User?> Create(UserDTO content);
  public Task<User?> FindById(string targetId);
  public Task<User?> FindByEmail(string targetEmail);
  public Task<List<User>> FindByType(UserType type);
  public Task<User?> UpdateById(string userId, UpdateUserDTO data);
  public Task<bool?> ChangeUserType(string userId, UserType type);
  public Task<User?> Remove(string userId);
}