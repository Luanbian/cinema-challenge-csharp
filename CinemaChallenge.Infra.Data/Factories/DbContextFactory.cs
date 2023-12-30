using CinemaChallenge.Domain.Entities;
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
                var config = new ConfigurationBuilder().AddUserSecrets<Movie>().Build();
                var connectionString = config.GetConnectionString("MyDatabaseConnection");
                Console.WriteLine(connectionString ?? "not found");
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            } catch (Exception ex)
            {
                Console.WriteLine($"Error configuring DbContext options: {ex.Message}");
                throw;
            }

        }
    }
}
