using Microsoft.AspNetCore.Identity.Entities;

namespace Microsoft.AspNetCore.Identity.Repositories;

public abstract class UserRepositoryBase(IdentityErrorDescriber describer)
    : UserStoreBase<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppUserToken, AppRoleClaim>(
        describer);