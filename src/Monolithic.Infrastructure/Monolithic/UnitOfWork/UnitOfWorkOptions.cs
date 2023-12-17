using System.Data;

namespace Monolithic.UnitOfWork
{
	public class UnitOfWorkOptions
	{
		/// <summary>
		/// Default: false.
		/// </summary>
		public bool IsTransactional { get; set; }

		public IsolationLevel? IsolationLevel { get; set; }

		/// <summary>
		/// Milliseconds
		/// </summary>
		public int? Timeout { get; set; }

		public UnitOfWorkOptions()
		{

		}

		public UnitOfWorkOptions(bool isTransactional = false, IsolationLevel? isolationLevel = null, int? timeout = null)
		{
			IsTransactional = isTransactional;
			IsolationLevel = isolationLevel;
			Timeout = timeout;
		}

		public UnitOfWorkOptions Clone()
		{
			return new UnitOfWorkOptions
			{
				IsTransactional = IsTransactional,
				IsolationLevel = IsolationLevel,
				Timeout = Timeout
			};
		}
	}
}
