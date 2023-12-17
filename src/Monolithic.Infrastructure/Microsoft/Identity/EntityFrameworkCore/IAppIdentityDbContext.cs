using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Monolithic.EntityFrameworkCore;

namespace Microsoft.Identity.EntityFrameworkCore
{
	public interface IAppIdentityDbContext : IAppIdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole,
		AppUserLogin, AppRoleClaim, AppUserToken>
	{
	}

	public interface IAppIdentityDbContext<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken> 
		: IEfCoreDbContext
		where TUser : IdentityUser<TKey>
		where TRole : IdentityRole<TKey>
		where TKey : IEquatable<TKey>
		where TUserClaim : IdentityUserClaim<TKey>
		where TUserRole : IdentityUserRole<TKey>
		where TUserLogin : IdentityUserLogin<TKey>
		where TRoleClaim : IdentityRoleClaim<TKey>
		where TUserToken : IdentityUserToken<TKey>
	{
		/// <summary>
		/// Gets or sets the <see cref="DbSet{TEntity}"/> of Users.
		/// </summary>
		DbSet<TUser> Users { get; }

		/// <summary>
		/// Gets or sets the <see cref="DbSet{TEntity}"/> of roles.
		/// </summary>
		DbSet<TRole> Roles { get; }

		/// <summary>
		/// Gets or sets the <see cref="DbSet{TEntity}"/> of User roles.
		/// </summary>
		DbSet<TUserRole> UserRoles { get; }

		/// <summary>
		/// Gets or sets the <see cref="DbSet{TEntity}"/> of role claims.
		/// </summary>
		DbSet<TRoleClaim> RoleClaims { get; }

		/// <summary>
		/// Gets or sets the <see cref="DbSet{TEntity}"/> of User claims.
		/// </summary>
		DbSet<TUserClaim> UserClaims { get; }

		/// <summary>
		/// Gets or sets the <see cref="DbSet{TEntity}"/> of User logins.
		/// </summary>
		DbSet<TUserLogin> UserLogins { get; }

		/// <summary>
		/// Gets or sets the <see cref="DbSet{TEntity}"/> of User tokens.
		/// </summary>
		DbSet<TUserToken> UserTokens { get; }
	}
}
