using System;

namespace Penso.Interfaces.Models
{
	public interface IUser
	{
		Guid Id { get; set; }
		string FirstName { get; set; }
		string MiddleName { get; set; }
		string LastName { get; set; }
		string Email { get; set; }
		DateTime CreatedOn { get; set; }
		DateTime ModifiedOn { get; set; }
		Guid ModifiedBy { get; set; }
	}
}
