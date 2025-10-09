using Domain.User.Dtos;
using Domain.User.Enums;

namespace Domain.User;

public interface IUserRepository
{
  public User? Create(CreateUserDTO content);
  public User? FindById(string targetId);
  public User? FindByEmail(string targetEmail);
  public List<User> FindByType(UserType type);
  public User? UpdateById(string userId, UpdateUserDTO data);
  public bool? ChangeUserType(string userId, UserType type);
  public User? Remove(string userId);
}