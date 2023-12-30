using CinemaChallenge.Infra.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CinemaChallenge.Infra.Data.Factories
{
    public class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            ConfigureDbContextOptions(optionsBuilder);
            return new AppDbContext(optionsBuilder.Options);
        }

        private static void ConfigureDbContextOptions(DbContextOptionsBuilder optionsBuilder)
        {
            try {
                string apiProjectPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "CinemaChallenge.API");
                var config = new ConfigurationBuilder()
                    .SetBasePath(apiProjectPath)
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = config.GetConnectionString("MyDatabaseConnection");
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            } catch (Exception ex)
            {
                Console.WriteLine($"Error configuring DbContext options: {ex.Message}");
                throw;
            }

        }
    }
}
