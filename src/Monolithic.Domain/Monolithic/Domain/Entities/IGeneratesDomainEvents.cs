namespace Monolithic.Domain.Entities;

public interface IGeneratesDomainEvents
{
	IEnumerable<DomainEventRecord> GetLocalEvents();

	IEnumerable<DomainEventRecord> GetDistributedEvents();

	void ClearLocalEvents();

	void ClearDistributedEvents();
}