using Microsoft.AspNetCore.Identity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Monolithic.EntityFrameworkCore;

namespace Microsoft.Identity.EntityFrameworkCore;

public class AppIdentityDbContext : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin,
		AppRoleClaim, AppUserToken>,
	IEfCoreDbContext
{
}