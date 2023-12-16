using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Monolithic.Domain.Entities;
using Monolithic.UnitOfWork;

namespace Monolithic.Domain.Repositories.EntityFrameworkCore;

public abstract class EfCoreRepository<TEntity> : IEfCoreRepository<TEntity>
	where TEntity : class, IEntity
{
	public IServiceProvider ServiceProvider { get; set; } = default!;
	public IUnitOfWorkManager UnitOfWorkManager => ServiceProvider.GetRequiredService<IUnitOfWorkManager>();


	public Task<IQueryable<TEntity>> GetQueryableAsync()
	{
		throw new NotImplementedException();
	}

	public Task<IQueryable<TEntity>> WithDetailsAsync()
	{
		throw new NotImplementedException();
	}

	public Task<IQueryable<TEntity>> WithDetailsAsync(params Expression<Func<TEntity, object>>[] propertySelectors)
	{
		throw new NotImplementedException();
	}

	public Task<TEntity?> FirstOrDefaultAsync(bool includeDetails = true, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails = true,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<TEntity> FirstAsync(bool includeDetails = true, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails = true,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<List<TEntity>> ToListAsync(CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<List<TEntity>> ToListAsync(Expression<Func<TEntity, bool>> predicate,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<TEntity[]> ToArrayAsync(CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<TEntity[]> ToArrayAsync(Expression<Func<TEntity, bool>> predicate,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<List<TEntity>> GetPagedListAsync(int skipCount, int maxResultCount, string sorting,
		bool includeDetails = false,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<List<TEntity>> GetPagedListAsync(Expression<Func<TEntity, bool>> predicate, int skipCount,
		int maxResultCount, string sorting,
		bool includeDetails = false, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<TEntity> InsertAsync(TEntity entity, bool autoSave = false,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task InsertManyAsync(IEnumerable<TEntity> entities, bool autoSave = false,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task DeleteAsync(Expression<Func<TEntity, bool>> predicate, bool autoSave = false,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task DeleteAsync(TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task DeleteManyAsync(Expression<Func<TEntity, bool>> predicate, bool autoSave = false,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task DeleteManyAsync(IEnumerable<TEntity> entities, bool autoSave = false,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task DeleteDirectAsync(Expression<Func<TEntity, bool>> predicate, bool autoSave,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task DeleteDirectAsync(TEntity entity, bool autoSave, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task DeleteDirectAsync(IEnumerable<TEntity> entities, bool autoSave,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<bool> AnyAsync(CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<bool> AllAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<int> CountAsync(CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<long> LongCountAsync(CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<long> LongCountAsync(Expression<Func<TEntity, bool>> predicate,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task MinAsync(CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<TEntity> MinAsync(Expression<Func<TEntity>> selector, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<TEntity> MaxAsync(CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<TEntity> MaxAsync(Expression<Func<TEntity>> selector, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public Task<DbContext> GetDbContextAsync()
	{
		throw new NotImplementedException();
	}

	public Task<DbSet<TEntity>> GetDbSetAsync()
	{
		throw new NotImplementedException();
	}
}