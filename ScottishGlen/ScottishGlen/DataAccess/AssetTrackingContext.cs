using Microsoft.EntityFrameworkCore;
using ScottishGlen.Models;

namespace ScottishGlen.DataAccess
{
    //This class will manage the database tables
    public class AssetTrackingContext : DbContext
    {
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
