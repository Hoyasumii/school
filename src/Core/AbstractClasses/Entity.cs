using Core.Interfaces;
using Core.ObjectValues;

namespace Core.AbstractClasses;

public abstract class Entity(string? id, DateTime? createdAt) : IEntity
{
  public Guid Id { get; } = id is null ?
                            Guid.NewGuid() : 
                            Guid.Parse(GuidOV.Make(id).Value);
  public DateTime CreatedAt { get; } = createdAt ?? DateTime.Now;
}