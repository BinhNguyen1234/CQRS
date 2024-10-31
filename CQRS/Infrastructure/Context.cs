using CQRS.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Infrastructure
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=170116Abc");
        }

        public DbSet<User> Users { get; set; }
    }
}
