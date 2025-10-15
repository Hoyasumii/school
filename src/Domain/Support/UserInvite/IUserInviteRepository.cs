namespace Domain.Support.UserInvite;

public interface IUserInviteRepository
{
  public Task Add(UserInvite data);
  public Task<UserInvite?> FindById(string id);
  public Task<bool> Remove(UserInvite data);
}
