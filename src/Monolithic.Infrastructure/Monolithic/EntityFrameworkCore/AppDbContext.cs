using Microsoft.EntityFrameworkCore;

namespace Monolithic.EntityFrameworkCore;

public abstract class AppDbContext : DbContext, IEfCoreDbContext
{
}