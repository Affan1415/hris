using Microsoft.AspNetCore.Mvc;

namespace hris.Controllers
{
	public class ProfileController : Controller
	{
		private readonly ApplicationDbContext _context;

		public ProfileController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult profile(int employeeId)
		{


			// Retrieve employee data based on the employeeId
			var employee = _context.EmployeeData.FirstOrDefault(e => e.EmployeeID == employeeId);

			if (employee == null)
			{
				// Handle the case where employee data is not found
				return NotFound();
			}

			return View(employee);
		}
	}

}
