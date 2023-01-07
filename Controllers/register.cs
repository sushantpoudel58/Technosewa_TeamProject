
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TechnoSewa.Models;
using TechnoSewa.Data;
using Microsoft.AspNetCore.Identity;

namespace TechnoSewa.Controllers
{
    public class register : Controller
    {

        string UserId;
        string Role1 ;
        private readonly ApplicationDbContext _context;
        public register(ApplicationDbContext context)
        {
            _context = context;
        }


        public ActionResult Index()
        {
            UserId=Request.Cookies["UserId"];
            Role1= Request.Cookies["Role1"];
            if (UserId != null )
            {
               if(Role1 == "client")
                return RedirectToAction(actionName: "Index", controllerName: "Home");

                else
                {
                    return RedirectToAction(actionName: "Index", controllerName: "Technician_Homepage");
                }

            }
            return View();

        }
        public ActionResult CreateProfile()
        {
            return View();

        }
        [HttpPost]
        public IActionResult CreateProfile(registerModel r1)
        {
            var test = ModelState.IsValid;
            if (ModelState.IsValid)
            {
                _context.tbl_register.Add(r1);
                _context.SaveChanges();



            }





            return RedirectToAction(actionName: "signin", controllerName: "register");
        }



      


        [HttpGet]

        public IActionResult signin()

        {

            registerModel _Model = new registerModel();

            return View(_Model);

        }
        [HttpPost]
        public IActionResult signin(registerModel _Model)

        {



            var status = _context.tbl_register.Where(m => m.Email == _Model.Email && m.Password == _Model.Password).FirstOrDefault();

            if (status == null)

            {

                ViewBag.LoginStatus = 0;
                return View();

            }

            else

            {

                var cookieOptions = new CookieOptions();

                cookieOptions.Expires = DateTime.Now.AddDays(30);
                cookieOptions.Path = "/";
                Response.Cookies.Append("UserId", status.UserId.ToString(), cookieOptions);
                Response.Cookies.Append("Role1", status.Role.ToString(), cookieOptions);


                if (status.Role == "Client")
                    return RedirectToAction("Index", "Home");
                else
                    return RedirectToAction("Index", "Technician");




            }
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



        }
    }


