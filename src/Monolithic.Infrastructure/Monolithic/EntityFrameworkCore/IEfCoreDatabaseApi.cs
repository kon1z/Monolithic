namespace Monolithic.EntityFrameworkCore
{
	public interface IEfCoreDatabaseApi
	{
		IEfCoreDbContext DbContext { get; }
	}
}
