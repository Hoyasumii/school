using Domain.Support.User.Enums;
using Domain.Support.User.Services.Interfaces;

namespace Domain.Support.User.Services.Strategies.RemovalUserService;

public sealed class StudentRemovalValidator : IUserRemovalValidator
{
  public UserType UserType { get; } = UserType.Student;

  public Task Validate(User user)
  {
    throw new NotImplementedException();
    // TODO: Adicionar uma validação para puxar de StudentEnrollment para ver se o aluno está vinculado num curso
  }
}