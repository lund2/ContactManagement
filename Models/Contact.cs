using System;
using System.Collections.Generic;

namespace ContactManagement.Models
{
	public class Contact
	{
		/*By default id is named the primary key*/
		public int Id { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime BirthDate { get; set; }


	}
}


