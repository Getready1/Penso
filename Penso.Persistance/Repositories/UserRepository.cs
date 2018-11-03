using Penso.Persistance.Models;
using Penso.Persistance.RepositoryInterfaces;

namespace Penso.Persistance.Repositories
{
	public class UserRepository : BaseRepository<User>,  IUserRepository
	{
		public UserRepository(PensoContext ctx) : base(ctx)
		{

		}
	}
}
