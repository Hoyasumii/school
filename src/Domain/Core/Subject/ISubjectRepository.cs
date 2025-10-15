namespace Domain.Core.Subject;

public interface ISubjectRepository
{
  public Task Add(Subject value);
  public Task<Subject?> FindById(string subjectId);
  public Task<ICollection<Subject>> FindByCourseId(string courseId);
  public Task<bool> Remove(Subject target);
}