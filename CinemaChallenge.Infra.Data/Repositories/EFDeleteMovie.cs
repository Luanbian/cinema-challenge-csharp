using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.EntityFramework;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Infra.Data.Repositories
{
    public class EFDeleteMovie(AppDbContext appDbContext) : IDeleteRepository
    {
        private readonly AppDbContext db = appDbContext;
        public void Delete(Guid id)
        {
            Movie? movie = db.Movies.Find(id);
            if (movie != null)
            {
                db.Movies.Remove(movie);
                db.SaveChanges();
            } else
            {
                throw new Exception("filme não encontrado");
            }
        }
    }
}
