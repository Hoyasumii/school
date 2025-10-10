using Domain.Class.Dtos;
using Domain.Class.Enums;

namespace Domain.Class;

public interface IClassRepository
{
  public Task<Class?> Create(ClassDTO data);
  // public IEnumerable<Class> FindById();
  public void FindByPeriod(int academicYear, Semester semester);
  public void FindBySubjectId();
  // public void FindBy
}