using BlazorApp1.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Person> Persons { get; set; }
    }
}
