using Core.ValueObjects;
using Domain.Core.Subject.Dtos;

namespace Domain.Core.Subject;

public static class SubjectFactory
{
  public static Subject Make(SubjectDTO data, string? id = null, DateTime? createdAt = null)
  {
    return new(id, createdAt)
    {
      Description = DefinedString.Make(data.Description),
      Name = DefinedString.Make(data.Name),
      CourseId = GuidVO.Make(data.CourseId),
      Active = data.Active
    };
  }
}
