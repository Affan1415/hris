namespace hris.Models
{
	public class EmployeeRegistrationViewModel
	{
		public string Email { get; set; }
		public string user { get; set; }

		public string Password { get; set; }
		public string UserType { get; set; }

		// Properties from EmployeeDataModel
		public string Name { get; set; }
		public string Designation { get; set; }
		public string ContactNumber { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public DateTime? JoiningDate { get; set; }
		public string CurrentAddress { get; set; }
		public string Gender { get; set; }
		public int? Salary { get; set; }
	}
}
