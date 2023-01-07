using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TechnoSewa.Data;
using TechnoSewa.Migrations;
using TechnoSewa.Models;

namespace TechnoSewa.Controllers
{
    public class Technician : Controller
    {
        string UserId;

        private readonly ApplicationDbContext _context;
        public Technician(ApplicationDbContext context)
        {
            _context = context;
        }

        // [HttpGet]
        // public async Task<IActionResult> Index(registerModel r1)
        // {

        //var UserId1 = Int32.Parse(Request.Cookies["UserId"]);
        //var user = await _context.tbl_register
        // .FirstOrDefaultAsync(m => m.UserId == UserId1);

        // List<registerModel> All_List = new List<registerModel>();




        // All_List.Add(_context.tbl_register.ToListAsync())

        // }

        //public IQueryable<register> TechnicianGrid_GetData()
        //{
        //    ApplicationDbContext db = new ApplicationDbContext();
        //    var query = db.tbl_register.Include<registerModel>( s.Role == "Technician");

        //}
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // var result = await _context.tbl_register.Where(x => x.Role == "Technician").ToListAsync();
            return View(await _context.tbl_register.Where(x => x.Role == "Technician").ToListAsync());
            //return View(result);
            // return View(await _context.profile.ToListAsync());
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
        public ActionResult Book()
        {
            return View();

        }





        [HttpPost]

        public IActionResult Index(Book b1)
        {
            int num = 1;


            var UserId1 = Int32.Parse(Request.Cookies["UserId"]);

            b1.book_value = num;
            b1.User.UserId = UserId1;
            _context.tbl_book.Add(b1);
            _context.SaveChanges();




            return RedirectToAction(actionName: "Book", controllerName: "Technician");






            //}


        }
    }
}
