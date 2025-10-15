using Core.ValueObjects;
using Domain.Core.Course.Dtos;

namespace Domain.Core.Course;

public static class CourseFactory
{
  public static Course Make(CourseDTO data, string? id = null, DateTime? createdAt = null)
  {
    return new(id, createdAt)
    {
      CoordinatorId = GuidVO.Make(data.CoordinatorId),
      Name = DefinedString.Make(data.Name)
    };
  }
}