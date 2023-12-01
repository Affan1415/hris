
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
    public IActionResult employeedashboard()
    {
        // Add any necessary logic for the admin dashboard
        return View();
        //return View("admindashboard");
    }
    [HttpGet]
    public IActionResult DisplayProfile(int employeeId)
    {
        // Retrieve employee data based on the employeeId
        var employee = _context.EmployeeData.FirstOrDefault(e => e.EmployeeID == employeeId);

        // Your logic to display the employee data in the profile view
        // ...

        return View(employee);
    }
}