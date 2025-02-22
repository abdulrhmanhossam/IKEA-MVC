using IKEA.DAL.Entities.Departments;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IKEA.DAL.Data;

class AppDbContext : DbContext
{
    public AppDbContext():base()
    {

    }

    public DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Server=.;Database=IKEADB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
