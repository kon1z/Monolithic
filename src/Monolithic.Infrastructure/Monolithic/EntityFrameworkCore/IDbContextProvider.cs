namespace Monolithic.EntityFrameworkCore
{
	public interface IDbContextProvider<TDbContext>
		where TDbContext : IEfCoreDbContext
	{
		Task<TDbContext> GetDbContextAsync();
	}
}
