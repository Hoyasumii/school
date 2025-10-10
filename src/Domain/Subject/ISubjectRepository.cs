using Domain.Subject.Dtos;

namespace Domain.Subject;

public interface ISubjectRepository
{
  public Task<Subject?> Create(SubjectDTO value);
  public Task<Subject?> FindById(string subjectId);
  public Task<Subject?> UpdateById(string subjectId, UpdateSubjectDTO data);
  public Task<Subject?> RemoveById(string subjectId);
}