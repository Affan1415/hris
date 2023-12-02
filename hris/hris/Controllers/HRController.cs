
using Microsoft.AspNetCore.Mvc;
using hris.Models.Authenticaton.login;
using hris.Models;
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

    [HttpGet]

    public IActionResult employeeslist(loginmodel loginform,EmployeeData employeeform)
    {

        return View();
    }
	[HttpPost]
	public IActionResult RegisterEmployee(EmployeeRegistrationViewModel viewModel)
	{
		if (ModelState.IsValid)
		{
			try
			{
				// Create a new LoginModel
				var loginModel = new loginmodel
				{
					Email = viewModel.Email,
					PasswordHash =viewModel.Password,
					_type = viewModel.UserType
				};

				// Add the LoginModel to the database
				_context.LoginTable.Add(loginModel);
				_context.SaveChanges();

				// Retrieve the newly created LoginModel's ID
				var loginId = loginModel.employeeid;

				// Create a new EmployeeDataModel
				var employeeDataModel = new EmployeeData
				{
					EmployeeID = loginId.Value,
					_type = viewModel.UserType,
					_Name = viewModel.Name,
					Designation = viewModel.Designation,
					ContactNumber = viewModel.ContactNumber,
					DateOfBirth = viewModel.DateOfBirth,
					JoiningDate = viewModel.JoiningDate,
					CurrentAddress = viewModel.CurrentAddress,
					Email = viewModel.Email,
					Gender = viewModel.Gender,
					Salary = viewModel.Salary
				};

				// Add the EmployeeDataModel to the database
				_context.EmployeeData.Add(employeeDataModel);
				_context.SaveChanges();

				return RedirectToAction("employeeslist");
			}
			catch (Exception ex)
			{
				_logger.LogError($"Error registering employee: {ex.Message}");
				ModelState.AddModelError("", "An error occurred while registering the employee.");
			}
		}

		return View(viewModel);
	}
}