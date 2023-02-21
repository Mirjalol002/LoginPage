using LoginPage.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginPage.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Host=localhost; port=5432; Database=TaskDb; User Id=postgres; Password=3;";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
