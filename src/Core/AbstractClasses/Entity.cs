using Core.Interfaces;
using Core.ValueObjects;

namespace Core.AbstractClasses;

public abstract class Entity(string? id, DateTime? createdAt) : IEntity
{
  public Guid Id { get; } = id is null ?
                            Guid.NewGuid() :
                            Guid.Parse(GuidVO.Make(id).Value);
  public DateTime CreatedAt { get; } = createdAt ?? DateTime.Now;
}