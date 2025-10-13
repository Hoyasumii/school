using Domain.Class;
using Domain.Support.User.Enums;
using Domain.Support.User.Services.Interfaces;

namespace Domain.Support.User.Services.Strategies.RemovalUserService;

public sealed class TeacherRemovalValidator(IClassRepository classRepository) : IUserRemovalValidator
{
  public UserType UserType { get; } = UserType.Teacher;
  private readonly IClassRepository ClassRepository = classRepository;

  public async Task Validate(User user)
  {
    var classesLinkedToTeacher = (await ClassRepository.FindByTeacherId(user.Id.ToString())).Count;

    if (classesLinkedToTeacher > 0) throw new Exception();
  }
}