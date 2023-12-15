using Microsoft.AspNetCore.Identity;
using Monolithic.Identity.Entities;
using Monolithic.Identity.Repositories;
using System.Security.Claims;

namespace Monolithic.Identity.EntityFrameworkCore.Repositories;

public class RoleRepository(IdentityErrorDescriber describer) : RoleRepositoryBase(describer)
{
	public override Task<IdentityResult> CreateAsync(AppRole role, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<IdentityResult> UpdateAsync(AppRole role, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<IdentityResult> DeleteAsync(AppRole role, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<AppRole?> FindByIdAsync(string id, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<AppRole?> FindByNameAsync(string normalizedName, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task<IList<Claim>> GetClaimsAsync(AppRole role, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task AddClaimAsync(AppRole role, Claim claim, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override Task RemoveClaimAsync(AppRole role, Claim claim, CancellationToken cancellationToken = new CancellationToken())
	{
		throw new NotImplementedException();
	}

	public override IQueryable<AppRole> Roles { get; }
}