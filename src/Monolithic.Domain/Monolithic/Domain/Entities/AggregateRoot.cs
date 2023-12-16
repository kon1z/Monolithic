namespace Monolithic.Domain.Entities;

[Serializable]
public abstract class AggregateRoot : BasicAggregateRoot, IHasConcurrencyStamp
{
	protected AggregateRoot()
	{
		ConcurrencyStamp = Guid.NewGuid().ToString("N");
	}

	public virtual string ConcurrencyStamp { get; set; }
}

[Serializable]
public abstract class AggregateRoot<TKey> : BasicAggregateRoot<TKey>, IHasConcurrencyStamp
	where TKey : IEquatable<TKey>
{
	protected AggregateRoot()
	{
		ConcurrencyStamp = Guid.NewGuid().ToString("N");
	}

	protected AggregateRoot(TKey id)
		: base(id)
	{
		ConcurrencyStamp = Guid.NewGuid().ToString("N");
	}

	public virtual string ConcurrencyStamp { get; set; }
}