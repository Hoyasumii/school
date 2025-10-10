using Domain.Class.Dtos;
using Domain.Class.Enums;

namespace Domain.Class;

public interface IClassRepository
{
  public Task<Class?> Create(ClassDTO data);
  public Task<Class?> FindById(string id);
  public Task<ICollection<Class>> FindBySubjectId(string id);
  public Task<ICollection<Class>> FindByTeacherId(string id);
  public Task<ICollection<Class>> FindByPeriod(int academicYear, Semester semester);
  public Task<Class?> UpdateById(string id, UpdateClassDTO data);
  public Task<Class?> RemoveById(string id);
  public Task<ICollection<Class>> RemoveBySubjectId(string id);
  public Task<ICollection<Class>> RemoveByTeacherId(string id);
}