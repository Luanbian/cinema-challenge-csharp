using CinemaChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CinemaChallenge.Infra.Data.EntityFramework
{
    public class AppDbContext : DbContext
    {
        private DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Movie>().Build();
            string connectionString = config.GetConnectionString("CinemaConnection")
                ?? throw new InvalidOperationException("A string de conexão não pode ser nula.");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
