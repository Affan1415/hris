
using Microsoft.AspNetCore.Mvc;

public class employeeController : Controller
{

    private readonly ILogger<employeeController> _logger;
    private readonly ApplicationDbContext _context;

    public employeeController(ILogger<employeeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }
    [HttpGet]
    [Route("employee/employeedashboard")]
    public IActionResult employeedashboard(int employeeId)
    {
        var employee = _context.EmployeeData.FirstOrDefault(e => e.EmployeeID == employeeId);
        // Add any necessary logic for the admin dashboard
        return View(employee);
        //return View("admindashboard");
    }
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
    [HttpGet]
    public IActionResult viewnoti()
    {
		var notification = _context.Notifications.ToList();
		return View(notification);
    }
	[HttpGet]
	public IActionResult projects()//view projects
	{
		// Add any necessary logic for the admin dashboard
		var projects = _context.ProjectData.ToList();

		return View(projects);
		//return View("admindashboard");
	}
}