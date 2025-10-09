using Domain.Subject.Dtos;

namespace Domain.Subject;

public interface ISubjectRepository
{
  public Subject? Create(SubjectDTO value);
  public Subject? FindById(string subjectId);
  public Subject? FindByCode(string subjectCode);
  public List<Subject> FindByTeacherId(string teacherId);
  public Subject? UpdateById(string subjectId, UpdateSubjectDTO data);
  public Subject? UpdateByCode(string subjectCode, UpdateSubjectDTO data);
  public Subject? RemoveById(string subjectId);
  public Subject? RemoveByCode(string subjectCode);
  public List<Subject> RemoveByTeacherId(string teacherId);
}