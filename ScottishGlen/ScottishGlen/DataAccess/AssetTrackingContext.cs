using Microsoft.EntityFrameworkCore;
using ScottishGlen.Models;

namespace ScottishGlen.DataAccess
{
    //This class will manage the database tables
    public class AssetTrackingContext : DbContext
    {
        public AssetTrackingContext(DbContextOptions<AssetTrackingContext> options) : base(options) { }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Asset>().ToTable("CMP307_ScottishGlenAssets");
            modelBuilder.Entity<Employee>().ToTable("CMP307_ScottishGlenEmployees");
            modelBuilder.Entity<Department>().ToTable("CMP307_ScottishGlenDepartments");

        }
    }
}
