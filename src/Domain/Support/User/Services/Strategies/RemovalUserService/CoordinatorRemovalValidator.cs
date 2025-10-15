using Domain.Core.Course;
using Domain.Support.User.Enums;
using Domain.Support.User.Services.Interfaces;

namespace Domain.Support.User.Services.Strategies.RemovalUserService;

public sealed class CoordinatorRemovalValidator(ICourseRepository courseRepository) : IUserRemovalValidator
{
  public UserType UserType { get; } = UserType.Coordinator;
  private readonly ICourseRepository CourseRepository = courseRepository;

  public async Task Validate(User user)
  {
    var coursesLinkedToTheCoordinator = (await CourseRepository.FindByCoordinatorId(user.Id.ToString())).Count;

    if (coursesLinkedToTheCoordinator > 0) throw new Exception();
  }
}