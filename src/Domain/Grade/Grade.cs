using Core.AbstractClasses;
using Core.ObjectValues;
using Domain.Grade.ObjectValues;

namespace Domain.Grade;

public sealed class Grade : Entity
{
  public required GuidVO GradeGroupId { get; init; }
  public required GuidVO EnrollmentId { get; init; }
  public required Score Score { get; init; }
}