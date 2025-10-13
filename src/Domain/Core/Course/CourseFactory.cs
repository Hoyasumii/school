using Core.ValueObjects;
using Domain.Course.Dtos;

namespace Domain.Course;

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