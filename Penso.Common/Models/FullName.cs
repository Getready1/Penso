using Penso.Interfaces.Models;

namespace Penso.Common.Models
{
	public class FullName : IFullName
	{
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
	}
}
