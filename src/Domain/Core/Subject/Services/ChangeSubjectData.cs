using Core.ValueObjects;
using Domain.Core.Subject.Dtos;

namespace Domain.Core.Subject.Services;

public sealed class ChangeSubjectData
{

  public static Subject Run(Subject subject, UpdateSubjectDTO data)
  {
    if (data.Name is not null)
      subject.Name = DefinedString.Make(data.Name);

    if (data.Description is not null)
      subject.Description = DefinedString.Make(data.Description);

    return subject;
  }

}