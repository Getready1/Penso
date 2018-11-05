using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Penso.Domain.ViewModels
{
	public class UserVM
	{
		public Guid UserId { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public DateTime CreatedOn { get; set; }
		public DateTime ModifiedOn { get; set; }
		public Guid ModifiedBy { get; set; }
	}
}