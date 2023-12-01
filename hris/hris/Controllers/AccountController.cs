// Controllers/AccountController.cs
using System.Linq;
using hris.Models.Authenticaton.login;
using Microsoft.AspNetCore.Mvc;
using hris.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;
    private readonly ApplicationDbContext _context;

    public AccountController(ILogger<AccountController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult Login()
    {
        var model = new hris.Models.Authenticaton.login.loginmodel();
        // Populate the model properties as needed
        return View(model);
    }

    [HttpPost]
    public IActionResult Login(loginmodel model)
    {
				return RedirectToAction("admindashboard","HR");
        if (ModelState.IsValid)
        {

            var user = _context.LoginTable.Where(u => u.Email == model.Email && u.PasswordHash == model.PasswordHash).FirstOrDefault(); 
			

			if (user != null)
            {
				// Authentication successful
				// Redirect to dashboard or perform necessary actions
				//Response.Redirect("./Views/HR/admindashboard.cshtml");
				//Response.WriteAsync("<script>alert('Error in login')</script>");
				//return View(admindashboard);
				//return View("Views/HR/");

			}
			else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt");
                return View();
            }
        }

        // If ModelState is not valid, return to the login view
        return View(model);
    }


}
