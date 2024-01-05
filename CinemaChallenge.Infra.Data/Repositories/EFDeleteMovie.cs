using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.EntityFramework;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Infra.Data.Repositories
{
    public class EFDeleteMovie(AppDbContext appDbContext) : IDeleteRepository
    {
        private readonly AppDbContext db = appDbContext;
        public async Task Delete(Guid id)
        {
            Movie? movie = await db.Movies.FindAsync(id);
            if (movie != null)
            {
                movie.IsDeleted = true;
                movie.DeletedAt = DateTime.Now;
                db.Movies.Update(movie);
                await db.SaveChangesAsync();
            } else
            {
                throw new Exception("filme não encontrado");
            }
        }
    }
}
