﻿
using hris.Models.Authenticaton.login;
using hris.Models;
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
    public IActionResult Profile(int employeeId)
    {
        // Retrieve employee data based on the employeeId
        var employee = _context.EmployeeData.FirstOrDefault(e => e.EmployeeID == employeeId);

        // Your logic to display the employee data in the profile view
        // ...

        return View();
    }

	[HttpGet]
	public IActionResult projects()//view projects
	{
		// Add any necessary logic for the admin dashboard
		var projects = _context.ProjectData.ToList();

		return View(projects);
		//return View("admindashboard");
	}

	[HttpPost]
	public IActionResult addproject(ProjectData project)//add projects
	{
		if (ModelState.IsValid)
		{
			// Assuming ProjectID is an identity column, it will be generated automatically
			_context.ProjectData.Add(project);
			_context.SaveChanges();

            // Redirect to a success page or another action
            return RedirectToAction("projectManagerdashboard", "projectManager");
            //return View();

        }

		// If the ModelState is not valid, return to the registration form with validation errors
		return View(project);
	}
    [HttpGet]
    public IActionResult add_project() {
        return View();
    }
}