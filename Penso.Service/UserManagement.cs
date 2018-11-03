using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Penso.Domain;
using Penso.Persistance.RepositoryInterfaces;
using Penso.Common.Mapper;
using Penso.Service.ServiceInterfaces;

namespace Penso.Service
{
	public class UserManagement : IUserManagement
	{
		private IUserRepository repository;

		public UserManagement(IUserRepository repository)
		{
			this.repository = repository;
		}

		public async Task<User> GetById(Guid id)
		{
			var user = await repository.GetById(id);
			return ModelMapper.Map<User>(user);
		}

		public async Task<IEnumerable<User>> ListAll()
		{
			var users = await repository.ListAll();
			return ModelMapper.Map<User>(users);
		}
	}
}
