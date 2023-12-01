
using Microsoft.AspNetCore.Mvc;

public class HRController : Controller
{
	[HttpGet]
	public IActionResult admindashboard()
	{
		// Add any necessary logic for the admin dashboard
		return View();
		//return View("admindashboard");
	}
}