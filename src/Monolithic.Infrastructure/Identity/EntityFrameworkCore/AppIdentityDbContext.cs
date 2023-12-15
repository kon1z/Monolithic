using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Monolithic.Identity.Entities;

namespace Monolithic.Identity.EntityFrameworkCore;

public class AppIdentityDbContext : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
{
	protected override void OnModelCreating(ModelBuilder builder)
	{
		// TODO
	}
}