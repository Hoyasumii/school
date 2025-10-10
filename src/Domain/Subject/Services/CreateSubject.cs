using Domain.Subject.Dtos;
using Domain.User;

namespace Domain.Subject.Services;

public sealed class CreateSubject(IUserRepository userRepository)
{
  private IUserRepository UserRepository { get; } = userRepository;

  public async Task<Subject> Run(SubjectDTO data)
  {
    _ = await UserRepository.FindById(data.CreatedBy) ?? throw new Exception();

    return SubjectFactory.Make(data);
  }
}
// TODO: Apenas Coordenadores podem fazer isso