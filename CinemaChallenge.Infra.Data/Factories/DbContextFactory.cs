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
            string apiProjectPath = Path.Combine("..", "CinemaChallenge.API");
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(apiProjectPath)
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = config.GetConnectionString("CinemaConnection");
            builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            return new AppDbContext(builder.Options);
        }
    }
}
