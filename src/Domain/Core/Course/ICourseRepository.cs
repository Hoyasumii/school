namespace Domain.Course;

public interface ICourseRepository
{
  public Task Add(Course data);
  public Task FindById(Course data);
  public Task<ICollection<Course>> FindByCoordinatorId(string coordinatorId);
  public Task Remove(Course target);
}