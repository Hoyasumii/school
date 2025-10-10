using Core.ObjectValues;
using Domain.Subject.Dtos;

namespace Domain.Subject;

public static class SubjectFactory
{
  public static Subject Make(SubjectDTO data, string? id, DateTime? createdAt)
  {
    return new(id, createdAt)
    {
      Description = DefinedString.Make(data.Description),
      Name = DefinedString.Make(data.Name),
      CreatedBy = GuidVO.Make(data.CreatedBy)
    };
  }
}
