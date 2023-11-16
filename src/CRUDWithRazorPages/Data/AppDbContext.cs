using CRUDWithRazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithRazorPages.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}