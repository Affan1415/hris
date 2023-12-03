using hris.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace hris.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _context;

		public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            // Your array
            string[] myArray = { "Item1", "Item2", "Item3" };

            // Create an instance of your model and assign the array
            

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
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
}