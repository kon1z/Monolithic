namespace Monolithic.DependencyInjection;

public interface IExposedServiceTypesProvider
{
	Type[] GetExposedServiceTypes(Type targetType);
}