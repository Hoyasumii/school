using Domain.Support.User.Services.Interfaces;

namespace Domain.Support.User.Services;

public sealed class RemovalUserDomainService(IUserRepository userRepository, IEnumerable<IUserRemovalValidator> validations)
{
  private readonly IUserRepository UserRepository = userRepository;
  private readonly IEnumerable<IUserRemovalValidator> Validations = validations;

  public async Task Run(User actor)
  {
    var strategy = Validations.FirstOrDefault(v => v.UserType == actor.Type.Value);

    if (strategy != null)
      await strategy.Validate(actor);

    await UserRepository.Remove(actor);
    // TODO: Adicionar um evento de remoção, como sequela da ação
  }
}