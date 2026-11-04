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

            //https://learn.microsoft.com/en-us/ef/core/modeling/relationships/one-to-many
            // was used for this.
            // employees can have multiple assets
            modelBuilder.Entity<Asset>()
                .HasOne<Employee>()
                .WithMany()
                .HasForeignKey(a => a.EmployeeId);

            // department can have multiple employees
            modelBuilder.Entity<Employee>()
                .HasOne<Department>()
                .WithMany()
                .HasForeignKey(e => e.DepartmentId);

            // the five departments
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "Finance" },
                new Department { DepartmentId = 2, DepartmentName = "Human Resources" },
                new Department { DepartmentId = 3, DepartmentName = "Operations" },
                new Department { DepartmentId = 4, DepartmentName = "Sales" },
                new Department { DepartmentId = 5, DepartmentName = "Information Technology" }
                );

        }
    }
}
