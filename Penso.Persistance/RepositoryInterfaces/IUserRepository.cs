using Penso.Interfaces.Repositories;
using Penso.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penso.Persistance.RepositoryInterfaces
{
	public interface IUserRepository : IUserRepository<User>
	{
	}
}
