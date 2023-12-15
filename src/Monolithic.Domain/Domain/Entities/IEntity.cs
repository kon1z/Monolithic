namespace Monolithic.Domain.Entities;

public interface IEntity
{
	object?[] GetKeys();
}

public interface IEntity<TKey> where TKey : IEquatable<TKey>
{
}