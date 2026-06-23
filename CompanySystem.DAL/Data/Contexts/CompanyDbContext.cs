using CompanySystem.BLL.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CompanySystem.BLL.Data.Contexts
{
    public class CompanyDbContext : DbContext
    {

        public CompanyDbContext

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Find Configuration and Apply it in this Assembly. 
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection string here
            optionsBuilder.UseSqlServer("Server=.;Database=CompanySystem.MVC;Trusted_Connection=True;TrustServerCertificate=true");
        }

        public DbSet<Department> Departments { get; set; }
    }
}
