
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class projectManagerController : Controller
{

    private readonly ILogger<projectManagerController> _logger;
    private readonly ApplicationDbContext _context;

    public projectManagerController(ILogger<projectManagerController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }
    [HttpGet]
    [Route("projectManager/projectManagerdashboard")]
    public IActionResult projectManagerdashboard()
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

        return View();
    }
}