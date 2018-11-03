using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Penso.Interfaces.Repositories
{
	public interface IBaseRepository<T>
	{
		Task<IEnumerable<T>> ListAll();
		Task<T> GetById(Guid id);
	}
}
