using Core.ObjectValues;
using Domain.Subject.Dtos;

namespace Domain.Subject;

public static class SubjectFactory
{
  public static Subject Make(SubjectDTO data)
  {
    return new()
    {
      Code = DefinedString.Make(data.Code),
      Description = DefinedString.Make(data.Description),
      Name = DefinedString.Make(data.Name),
      TeacherId = GuidOV.Make(data.TeacherId)
    };
  }
}
