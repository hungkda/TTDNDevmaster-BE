using Lession06.Theory.Models;
using Microsoft.EntityFrameworkCore;

namespace Lession06.Theory.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }    
    }
}
