using Microsoft.AspNetCore.Identity.Entities;

namespace Microsoft.AspNetCore.Identity.Repositories;

public abstract class RoleRepositoryBase(IdentityErrorDescriber describer)
    : RoleStoreBase<AppRole, Guid, AppUserRole, AppRoleClaim>(describer);