using Microsoft.EntityFrameworkCore;
using Villa_API.Models;

namespace Villa_API.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Villa_API.Models.Villa> Villas { get; set; }


        }
}
