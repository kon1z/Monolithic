using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Monolithic.Domain.Entities;

namespace Monolithic.Domain.Repositories;

public interface IRepository
{
}

public interface IRepository<TEntity> : IRepository
	where TEntity : IEntity
{
	Task<IQueryable<TEntity>> GetQueryableAsync();
	Task<IQueryable<TEntity>> WithDetailsAsync();
	Task<IQueryable<TEntity>> WithDetailsAsync(params Expression<Func<TEntity, object>>[] propertySelectors);

	Task<TEntity?> FirstOrDefaultAsync(bool includeDetails = true, CancellationToken cancellationToken = default);

	Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails = true,
		CancellationToken cancellationToken = default);

	Task<TEntity> FirstAsync(bool includeDetails = true, CancellationToken cancellationToken = default);

	Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate, bool includeDetails = true,
		CancellationToken cancellationToken = default);

	Task<List<TEntity>> ToListAsync(CancellationToken cancellationToken = default);

	Task<List<TEntity>> ToListAsync(Expression<Func<TEntity, bool>> predicate,
		CancellationToken cancellationToken = default);

	Task<TEntity[]> ToArrayAsync(CancellationToken cancellationToken = default);

	Task<TEntity[]> ToArrayAsync(Expression<Func<TEntity, bool>> predicate,
		CancellationToken cancellationToken = default);

	Task<List<TEntity>> GetPagedListAsync(int skipCount, int maxResultCount, string sorting,
		bool includeDetails = false, CancellationToken cancellationToken = default);

	Task<List<TEntity>> GetPagedListAsync(Expression<Func<TEntity, bool>> predicate, int skipCount, int maxResultCount,
		string sorting, bool includeDetails = false, CancellationToken cancellationToken = default);

	Task<TEntity> InsertAsync([NotNull] TEntity entity, bool autoSave = false,
		CancellationToken cancellationToken = default);

	Task InsertManyAsync(IEnumerable<TEntity> entities, bool autoSave = false,
		CancellationToken cancellationToken = default);

	Task DeleteAsync(Expression<Func<TEntity, bool>> predicate, bool autoSave = false,
		CancellationToken cancellationToken = default);

	Task DeleteAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default);

	Task DeleteManyAsync(Expression<Func<TEntity, bool>> predicate, bool autoSave = false,
		CancellationToken cancellationToken = default);

	Task DeleteManyAsync(IEnumerable<TEntity> entities, bool autoSave = false,
		CancellationToken cancellationToken = default);

	Task DeleteDirectAsync(Expression<Func<TEntity, bool>> predicate, bool autoSave,
		CancellationToken cancellationToken = default);

	Task DeleteDirectAsync([NotNull] TEntity entity, bool autoSave, CancellationToken cancellationToken = default);
	Task DeleteDirectAsync(IEnumerable<TEntity> entities, bool autoSave, CancellationToken cancellationToken = default);

	#region Any/All

	Task<bool> AnyAsync(CancellationToken cancellationToken = default);
	Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
	Task<bool> AllAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

	#endregion

	#region Count/LongCount

	Task<int> CountAsync(CancellationToken cancellationToken = default);
	Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
	Task<long> LongCountAsync(CancellationToken cancellationToken = default);
	Task<long> LongCountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

	#endregion

	#region Min

	Task MinAsync(CancellationToken cancellationToken = default);

	Task<TEntity> MinAsync(Expression<Func<TEntity>> selector, CancellationToken cancellationToken = default);

	#endregion

	#region Max

	Task<TEntity> MaxAsync(CancellationToken cancellationToken = default);

	Task<TEntity> MaxAsync(Expression<Func<TEntity>> selector, CancellationToken cancellationToken = default);

	#endregion
}

public interface IRepository<TEntity, TKey> : IRepository<TEntity>
	where TEntity : IEntity<TKey>
	where TKey : IEquatable<TKey>
{
	Task<TEntity?> FirstOrDefaultAsync(TKey id, bool includeDetails = true,
		CancellationToken cancellationToken = default);

	Task<TEntity> FirstAsync(TKey id, bool includeDetails = true, CancellationToken cancellationToken = default);
	Task DeleteAsync(TKey id, bool autoSave = false, CancellationToken cancellationToken = default);
	Task DeleteManyAsync(IEnumerable<TKey> ids, bool autoSave = false, CancellationToken cancellationToken = default);
	Task DeleteDirectAsync(TKey id, bool autoSave, CancellationToken cancellationToken = default);
	Task DeleteDirectAsync(IEnumerable<TKey> ids, bool autoSave, CancellationToken cancellationToken = default);
}