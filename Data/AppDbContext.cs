using CRUDOPproject.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDOPproject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
