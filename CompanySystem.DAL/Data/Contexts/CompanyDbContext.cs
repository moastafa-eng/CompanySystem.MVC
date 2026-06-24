using CompanySystem.BLL.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CompanySystem.BLL.Data.Contexts
{
    public class CompanyDbContext : DbContext
    {

        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Find Configuration and Apply it in this Assembly. 
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Department> Departments { get; set; }
    }
}
