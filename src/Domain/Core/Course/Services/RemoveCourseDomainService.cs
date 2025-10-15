using Domain.Core.Subject;

namespace Domain.Core.Course.Services;

public sealed class RemoveCourseDomainService(ICourseRepository courseRepository, ISubjectRepository subjectRepository)
{
  private readonly ICourseRepository _courseRepository = courseRepository;
  private readonly ISubjectRepository _subjectRepository = subjectRepository;

  public async Task Run(Course course)
  {
    var subjects = await _subjectRepository.FindByCourseId(course.Id.ToString());

    if (subjects.Any(subject => subject.Active)) throw new Exception();

    await _courseRepository.Remove(course);
  }
}