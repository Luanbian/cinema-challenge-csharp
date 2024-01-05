using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Domain.Interfaces;
using CinemaChallenge.Infra.Data.EntityFramework;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Infra.Data.Repositories
{
    public class EFUpdateMovie(AppDbContext appDbContext) : IUpdateRepository<IMovie>
    {
        private readonly AppDbContext db = appDbContext;

        public async Task Update(Guid id, IMovie data)
        {
            Movie? movie = await db.Movies.FindAsync(id);
            if (movie == null) return;
            movie.Title = data.Title ?? movie.Title;
            movie.Synopsis = data.Synopsis ?? movie.Synopsis;
            movie.ReleaseDate = data.ReleaseDate ?? movie.ReleaseDate;

            db.Movies.Update(movie);
            await db.SaveChangesAsync();
        }
    }
}
