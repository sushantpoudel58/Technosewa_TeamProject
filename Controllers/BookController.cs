using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechnoSewa.Data;

namespace TechnoSewa.Controllers
{
    public class BookController : Controller
    {
        string UserId;

        private readonly ApplicationDbContext _context;
        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //    public async Task<IActionResult> Index()
        //    {
        //        // var result = await _context.tbl_register.Where(x => x.Role == "Technician").ToListAsync();
        //        return View(await _context.tbl_book.Where(x => x.book_value == 1).ToListAsync());
        //        //return View(result);
        //        // return View(await _context.profile.ToListAsync());
        //    }


        public IActionResult Index()
        {
            return View();
        }




    }
}
