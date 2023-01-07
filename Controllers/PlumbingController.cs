using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using TechnoSewa.Migrations;
using TechnoSewa.Models;
using TechnoSewa.Data;

namespace TechnoSewa.Controllers
{
    public class Plumbing: Controller
    {
       // string UserId = "null";
        private readonly ApplicationDbContext _context1;
        public Plumbing(ApplicationDbContext context)
        {
            _context1 = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(SubmitProblemModel sp1)
         
        {
            //  var UserId = Int32.Parse(Request.Cookies["UserId"]);
            //var UserId1 = Request.Cookies["UserId"];
            var UserId1 = Int32.Parse(Request.Cookies["UserId"]);
            var user = await _context1.tbl_register
             .FirstOrDefaultAsync(m => m.UserId == UserId1);
            sp1.User = user;
            _context1.tbl_problem.Add(sp1);
            _context1.SaveChanges();




            return RedirectToAction(actionName: "Index", controllerName: "Technician");
        }


    }
}
