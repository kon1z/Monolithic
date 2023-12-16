using Microsoft.EntityFrameworkCore;
using Monolithic.Domain.Entities;

namespace Monolithic.Domain.Repositories.EntityFrameworkCore;

public interface IEfCoreRepository<TEntity> : IRepository<TEntity>
	where TEntity : class, IEntity
{
	Task<DbContext> GetDbContextAsync();

	Task<DbSet<TEntity>> GetDbSetAsync();
}

public interface IEfCoreRepository<TEntity, TKey> : IRepository<TEntity, TKey>
	where TEntity : class, IEntity<TKey>
	where TKey : IEquatable<TKey>
{
}