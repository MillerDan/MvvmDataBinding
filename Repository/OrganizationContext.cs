using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class OrganizationContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MinUwp.db");
        }
    }
}
