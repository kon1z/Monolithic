namespace Monolithic.UnitOfWork;

public interface IUnitOfWorkManager
{
	IUnitOfWork? CurrentUow { get; }
}