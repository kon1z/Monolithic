using Microsoft.EntityFrameworkCore;

namespace Monolithic.EntityFrameworkCore;

public abstract class AppDbContext : DbContext, IEfCoreDbContext, IEfCoreDatabaseApi
{
	public IEfCoreDbContext DbContext => throw new NotImplementedException();
}