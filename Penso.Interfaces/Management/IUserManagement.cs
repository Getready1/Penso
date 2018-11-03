using Penso.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Penso.Interfaces.Management
{
	public interface IUserManagement<T>
	{
		Task<IEnumerable<T>> ListAll();
		Task<T> GetById(Guid id);
	}
}
