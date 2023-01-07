using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using TechnoSewa.Models;

namespace TechnoSewa.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TechnoSewa.Models.registerModel> tbl_register { get; set; }
        public DbSet<TechnoSewa.Models.SubmitProblemModel> tbl_problem { get; set; }
        public DbSet<TechnoSewa.Models.Book> tbl_book { get; set; }



    }
}