using Microsoft.AspNetCore.Identity;
using Monolithic.Identity.Entities;

namespace Monolithic.Identity.Repositories;

public abstract class RoleRepositoryBase(IdentityErrorDescriber describer)
	: RoleStoreBase<AppRole, Guid, AppUserRole, AppRoleClaim>(describer);