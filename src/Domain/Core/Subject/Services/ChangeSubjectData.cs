using Core.ValueObjects;
using Domain.Subject.Dtos;

namespace Domain.Subject.Services;

public sealed class ChangeSubjectData
{

  public static async Task<Subject> Run(Subject subject, UpdateSubjectDTO data)
  {
    if (data.Name is not null)
      subject.Name = DefinedString.Make(data.Name);

    if (data.Description is not null)
      subject.Description = DefinedString.Make(data.Description);

    return subject;
  }

}