using Core.ValueObjects;
using Domain.Class.Dtos;
using Domain.Class.ValueObjects;

namespace Domain.Class;

public static class ClassFactory
{
  public static Class Make(ClassDTO data, string? id = null, DateTime? createdAt = null)
  {
    return new(id, createdAt)
    {
      AcademicYear = AcademicYear.Make(data.AcademicYear),
      CreatedBy = GuidVO.Make(data.CreatedBy),
      Name = DefinedString.Make(data.Name),
      Semester = Semester.Make(data.Semester),
      SubjectId = GuidVO.Make(data.SubjectId),
      Active = data.Active,
      TeacherId = GuidVO.Make(data.TeacherId)
    };
  }
}