using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechnoSewa.Models;

namespace TechnoSewa.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Bookings()
        {
            return View();
        }
        public IActionResult Notifications()
        {
            return View();
        }
       
            public IActionResult signout()

            {
                //CookieOptions.Expires = DateTime.Now.AddSeconds(1);
                // Session.Abandon();
                //HttpContext.Current.Session.Abandon();
                //string v = Request.Cookies["UserId"];
                var cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Append("UserId", "null", cookieOptions);
                var cookieOptions1 = new CookieOptions();
                cookieOptions1.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Append("Role1", "null", cookieOptions);
                //  Response.Cookies.Append("SomeCookie", "null", cookieOptions);
                //  var UserId = Int32.Parse(Request.Cookies["UserId"]);

                return RedirectToAction(actionName: "signin", controllerName: "register");


            }
          
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}