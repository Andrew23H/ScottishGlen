using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

// this was created as EF core nneds a way to create database context when it is genberating migrations

namespace ScottishGlen.DataAccess
{
    public class AssetTrackingContextFactory
        : IDesignTimeDbContextFactory<AssetTrackingContext>
    {
        public AssetTrackingContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .AddUserSecrets<AssetTrackingContextFactory>()
                .Build();

            string connectionString = configuration
                .GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException(
                    "Database connection string was not found.");

            var options = new DbContextOptionsBuilder<AssetTrackingContext>()
                .UseMySql(
                    connectionString,
                    ServerVersion.AutoDetect(connectionString))
                .Options;

            return new AssetTrackingContext(options);
        }
    }
}