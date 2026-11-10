using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ScottishGlen.DataAccess;
using ScottishGlen.Forms;

// https://learn.microsoft.com/en-gb/aspnet/core/fundamentals/configuration/?view=aspnetcore-10.0 , https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/ , https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql/blob/main/src/EFCore.MySql/Extensions/MySqlDbContextOptionsBuilderExtensions.cs
// These were used to figure out how to use EF Core, load the database settings from the JSON file and connect to the database 
namespace ScottishGlen
{
    internal static class Program
    {

        // this will allow other Forms to use the database
        internal static AssetTrackingContext CreateDbContext()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .AddUserSecrets(typeof(Program).Assembly)
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<AssetTrackingContext>()
                .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .Options;

          return new AssetTrackingContext(options); 

        }
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // This will load the database configuration from appsettings.json,
            // The credentials are stored seperately in User Secrets
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddUserSecrets(typeof(Program).Assembly).Build();

            // This will get the database connection string
            string connectionString = configuration.GetConnectionString("DefaultConnection");

            // This will configure entity framework core to use  pomelo MySQL
            var options = new DbContextOptionsBuilder<AssetTrackingContext>()
                .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)).Options;
            using var dbContext = new AssetTrackingContext(options);

            try
            {
                if (dbContext.Database.CanConnect())
                {
                    MessageBox.Show("Successful Connection!!");
                }
                else
                {
                    MessageBox.Show("Failed connection to database!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failure: {ex.Message}");
            }
            Application.Run(new MainMenuForm());
        }
    }
}