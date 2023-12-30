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

        private void ConfigureDbContextOptions(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Movie>().Build();
            var connectionString = config.GetConnectionString("CinemaConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
