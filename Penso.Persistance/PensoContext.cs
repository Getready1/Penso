using Penso.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penso.Persistance
{
	public class PensoContext : DbContext
	{
		public PensoContext() : base("PensoConnection")
		{

		}

		public DbSet<User> Users { get; set; }
	}
}
