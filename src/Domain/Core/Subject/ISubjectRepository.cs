using Domain.Subject.Dtos;

namespace Domain.Subject;

public interface ISubjectRepository
{
  public Task Add(Subject value);
  public Task<Subject?> FindById(string subjectId);
  public Task<bool> Remove(Subject target);
}