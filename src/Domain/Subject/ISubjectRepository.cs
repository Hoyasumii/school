using Domain.Subject.Dtos;

namespace Domain.Subject;

public interface ISubjectRepository
{
  public Subject? Create(SubjectDTO value);
  public Subject? FindById(string subjectId);
  public Subject? UpdateById(string subjectId, UpdateSubjectDTO data);
  public Subject? RemoveById(string subjectId);
}