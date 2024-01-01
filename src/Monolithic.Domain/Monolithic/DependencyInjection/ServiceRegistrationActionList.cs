namespace Monolithic.DependencyInjection;

public class ServiceRegistrationActionList : List<Action<IOnServiceRegisteredContext>>
{
	public bool IsClassInterceptorsDisabled { get; set; }
}