
using Microsoft.AspNetCore.Mvc;

public class HRController : Controller
{
    private readonly ILogger<HRController> _logger;
    private readonly ApplicationDbContext _context;

    public HRController(ILogger<HRController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }
    [HttpGet]
    [Route("HR/admindashboard")]
    public IActionResult admindashboard(int employeeId)
	{
		var employee = _context.EmployeeData.FirstOrDefault(e => e.EmployeeID == employeeId);
		// Add any necessary logic for the admin dashboard
		return View(employee);
		//return View("admindashboard");
	}
    // ProfileCntroller
    [HttpGet]
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