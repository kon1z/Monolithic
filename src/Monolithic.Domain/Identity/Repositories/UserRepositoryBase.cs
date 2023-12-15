using Microsoft.AspNetCore.Identity;
using Monolithic.Identity.Entities;

namespace Monolithic.Identity.Repositories;

public abstract class UserRepositoryBase(IdentityErrorDescriber describer)
	: UserStoreBase<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppUserToken, AppRoleClaim>(
		describer);