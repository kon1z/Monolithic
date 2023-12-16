namespace Monolithic.Domain.Entities;

public class DomainEventRecord(object eventData, long eventOrder)
{
	public object EventData { get; } = eventData;

	public long EventOrder { get; } = eventOrder;
}