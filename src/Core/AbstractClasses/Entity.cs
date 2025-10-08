namespace Core.AbstractClasses;

public abstract class Entity
{
  public Guid Id { get; } = Guid.NewGuid();
  public DateTime CreatedAt { get; } = DateTime.Now;
}