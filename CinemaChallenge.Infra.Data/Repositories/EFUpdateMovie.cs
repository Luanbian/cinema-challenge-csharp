using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Domain.Interfaces;
using CinemaChallenge.Infra.Data.EntityFramework;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Infra.Data.Repositories
{
    public class EFUpdateMovie(AppDbContext appDbContext) : IUpdateRepository<IMovie>
    {
        private readonly AppDbContext db = appDbContext;

        public void Update(Guid id, IMovie data)
        {
            Movie? movie = db.Movies.Find(id);
            if (movie == null) return;
        }
    }
}
