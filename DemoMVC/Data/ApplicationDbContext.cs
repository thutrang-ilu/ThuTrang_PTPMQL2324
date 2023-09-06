using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;
namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext>options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set;}
        public DbSet<Person> Persons {get; set;}
        public DbSet<DemoMVC.Models.Employee> Employee { get; set; } = default!;
        public DbSet<DemoMVC.Models.Customer> Customer { get; set; } = default!;
        public DbSet<DemoMVC.Models.Faculty> Faculty { get; set; } = default!;
    }
}