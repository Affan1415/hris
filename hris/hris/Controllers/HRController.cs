
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

				var employeeDataModel = new EmployeeData
				{
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

				var loginId = employeeDataModel.EmployeeID;

				// Create a new LoginModel
				var loginModel = new loginmodel
				{
					employeeid = loginId,
					Email = viewModel.Email,
					PasswordHash = viewModel.Password, 
					_type = viewModel.UserType
				};

				// Add the LoginModel to the database
				_context.LoginTable.Add(loginModel);
				_context.SaveChanges();

				// Retrieve the newly created LoginModel's ID

				// Create a new EmployeeDataModel

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