
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
    public IActionResult admindashboard()
	{
		// Add any necessary logic for the admin dashboard
		return View();
		//return View("admindashboard");
	}
    // ProfileCntroller
    [HttpGet]
    public IActionResult DisplayProfile(int employeeId)
    {
        // Retrieve employee data based on the employeeId
        var employee = _context.EmployeeData.FirstOrDefault(e => e.EmployeeID == employeeId);

        // Your logic to display the employee data in the profile view
        // ...

        return View();
    }

}