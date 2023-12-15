namespace Monolithic.Domain.Entities;

public abstract class Entity : IEntity
{
	public abstract object?[] GetKeys();
}

public abstract class Entity<TKey> : IEntity<TKey>
	where TKey : IEquatable<TKey>
{
	public virtual TKey Id { get; protected set; } = default!;
}