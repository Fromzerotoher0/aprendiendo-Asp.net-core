using Microsoft.EntityFrameworkCore;
using webApiAutores.entities;

namespace webApiAutores
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Author> Authors { get; set; }
    }
}
