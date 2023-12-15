using Microsoft.AspNetCore.Identity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.EntityFrameworkCore;

public class AppIdentityDbContext : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
{
	protected override void OnModelCreating(ModelBuilder builder)
	{
		// TODO
	}
}