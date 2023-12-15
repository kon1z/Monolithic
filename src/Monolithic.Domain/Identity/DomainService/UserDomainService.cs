using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Monolithic.Identity.Entities;

namespace Monolithic.Identity.DomainService;

public class UserDomainService(
	IUserStore<AppUser> store,
	IOptions<IdentityOptions> optionsAccessor,
	IPasswordHasher<AppUser> passwordHasher,
	IEnumerable<IUserValidator<AppUser>> userValidators,
	IEnumerable<IPasswordValidator<AppUser>> passwordValidators,
	ILookupNormalizer keyNormalizer,
	IdentityErrorDescriber errors,
	IServiceProvider services,
	ILogger<UserManager<AppUser>> logger)
	: UserManager<AppUser>(store, optionsAccessor, passwordHasher, userValidators, passwordValidators,
		keyNormalizer, errors, services, logger)
{

}