using CinemaChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CinemaChallenge.Infra.Data.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string apiProjectPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "CinemaChallenge.API");
            var config = new ConfigurationBuilder()
                .SetBasePath(apiProjectPath)
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetConnectionString("MyDatabaseConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
