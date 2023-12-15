using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Entities;
using Microsoft.AspNetCore.Identity.Repositories;

namespace Identity.EntityFrameworkCore.Repositories;

public class UserRepository(IdentityErrorDescriber describer) : UserRepositoryBase(describer)
{
	public override Task<IdentityResult> CreateAsync(AppUser user, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<IdentityResult> UpdateAsync(AppUser user, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<IdentityResult> DeleteAsync(AppUser user, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<AppUser?> FindByIdAsync(string userId, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<AppUser?> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	protected override Task<AppUser?> FindUserAsync(Guid userId, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	protected override Task<AppUserLogin?> FindUserLoginAsync(Guid userId, string loginProvider, string providerKey, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	protected override Task<AppUserLogin?> FindUserLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public override Task<IList<Claim>> GetClaimsAsync(AppUser user, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task AddClaimsAsync(AppUser user, IEnumerable<Claim> claims, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task ReplaceClaimAsync(AppUser user, Claim claim, Claim newClaim,
		CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task RemoveClaimsAsync(AppUser user, IEnumerable<Claim> claims, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<IList<AppUser>> GetUsersForClaimAsync(Claim claim, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	protected override Task<AppUserToken?> FindTokenAsync(AppUser user, string loginProvider, string name, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	protected override Task AddUserTokenAsync(AppUserToken token)
	{
		throw new NotImplementedException();
	}

	protected override Task RemoveUserTokenAsync(AppUserToken token)
	{
		throw new NotImplementedException();
	}

	public override IQueryable<AppUser> Users { get; }

	public override Task AddLoginAsync(AppUser user, UserLoginInfo login, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task RemoveLoginAsync(AppUser user, string loginProvider, string providerKey,
		CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<IList<UserLoginInfo>> GetLoginsAsync(AppUser user, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<AppUser?> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<bool> IsInRoleAsync(AppUser user, string normalizedRoleName,
		CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	protected override Task<AppRole?> FindRoleAsync(string normalizedRoleName, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	protected override Task<AppUserRole?> FindUserRoleAsync(Guid userId, Guid roleId, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public override Task<IList<AppUser>> GetUsersInRoleAsync(string normalizedRoleName, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task AddToRoleAsync(AppUser user, string normalizedRoleName,
		CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task RemoveFromRoleAsync(AppUser user, string normalizedRoleName,
		CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<IList<string>> GetRolesAsync(AppUser user, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}
}