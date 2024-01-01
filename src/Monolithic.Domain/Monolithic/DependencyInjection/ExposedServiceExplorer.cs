using Monolithic.DependencyInjection.Attributes;

namespace Monolithic.DependencyInjection;

public static class ExposedServiceExplorer
{
	private static readonly ExposeServicesAttribute DefaultExposeServicesAttribute =
		new ExposeServicesAttribute
		{
			IncludeDefaults = true,
			IncludeSelf = true
		};

	public static List<Type> GetExposedServices(Type type)
	{
		return type
			.GetCustomAttributes(true)
			.OfType<IExposedServiceTypesProvider>()
			.DefaultIfEmpty(DefaultExposeServicesAttribute)
			.SelectMany(p => p.GetExposedServiceTypes(type))
			.Distinct()
			.ToList();
	}
}