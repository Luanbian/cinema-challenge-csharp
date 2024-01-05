using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.EntityFramework;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Infra.Data.Repositories
{
    public class EFCreateMovie(AppDbContext appDbContext) : ICreateRepository<Movie>
    {
        private readonly AppDbContext db = appDbContext;
        public async Task Create(Movie data)
        {
            db.Movies.Add(data);
            await db.SaveChangesAsync();
        }
    }
}
