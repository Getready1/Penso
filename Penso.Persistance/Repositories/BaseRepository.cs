using Penso.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Penso.Persistance.Repositories
{
	public class BaseRepository<T> : IBaseRepository<T> where T: class
	{
		private PensoContext ctx;
		private DbSet<T> dbSet;

		public BaseRepository(PensoContext ctx)
		{
			this.ctx = ctx;
			this.dbSet = ctx.Set<T>();
		}

		public async Task<T> GetById(Guid id) => await dbSet.FindAsync();

		public async Task<IEnumerable<T>> ListAll() => await dbSet.ToListAsync();
	}
}
