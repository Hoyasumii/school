using Core.AbstractClasses;
using Microsoft.EntityFrameworkCore;

namespace Core.Interfaces;

public interface IDomainRepositoryContext<DomainType> where DomainType : Entity
{
  public Task<int> Save();
  public DbSet<DomainType> Collection { get;  }
}