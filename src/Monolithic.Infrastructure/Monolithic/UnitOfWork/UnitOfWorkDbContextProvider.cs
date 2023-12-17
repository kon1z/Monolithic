using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Monolithic.EntityFrameworkCore;

namespace Monolithic.UnitOfWork
{
	public class UnitOfWorkDbContextProvider<TDbContext>(
		IUnitOfWorkManager unitOfWorkManager, 
		IConfiguration configuration,
		IOptions<UnitOfWorkOptions> uowOptions)
        : IDbContextProvider<TDbContext>
        where TDbContext : IEfCoreDbContext
	{
		private UnitOfWorkOptions Options => uowOptions.Value ?? new UnitOfWorkOptions()
		{

		};

        public Task<TDbContext> GetDbContextAsync()
        {
            var unitOfWork = unitOfWorkManager.CurrentUow;
            if (unitOfWork == null)
            {
                throw new AppException("DbContext只在工作单元中执行，请开启工作单元！");
            }

            var connectionStringName = ConnectionStringNameAttribute.GetConnStringName<TDbContext>();
            var connectionString = configuration.GetConnectionString(connectionStringName);

            throw new NotImplementedException();
        }

        private async Task<TDbContext> CreateDbContextAsync(IUnitOfWork unitOfWork, string connectionStringName, string conn)
        {
            throw new NotImplementedException();
        }
    }
}
