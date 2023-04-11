using LoginDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoginDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult VerifyLogin()
        {
            string username = Request.Form["txtUsername"].ToString();
            string pass = Request.Form["txtPass"].ToString();

            User hm = new User("Sean","123");

            if (username.Equals(hm.Username) && pass.Equals(hm.Password))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Login");
            }
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
    }
}