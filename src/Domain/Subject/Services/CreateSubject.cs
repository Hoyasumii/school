using Domain.Subject.Dtos;
using Domain.User;

namespace Domain.Subject.Services;

public sealed class CreateSubject(IUserRepository userRepository)
{
  private IUserRepository UserRepository { get; } = userRepository;

  public async Task<Subject> Run(SubjectDTO data)
  {
    var targetCoordinator = await UserRepository.FindById(data.CreatedBy)
                            ?? throw new Exception();

    if (targetCoordinator.Type.Value != User.Enums.UserType.Coordinator)
      throw new Exception();

    return SubjectFactory.Make(data);
  }
}