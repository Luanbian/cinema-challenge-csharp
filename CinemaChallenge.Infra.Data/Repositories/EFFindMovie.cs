using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.EntityFramework;
using CinemaChallenge.Infra.Data.Interfaces;
using System.Linq.Expressions;

namespace CinemaChallenge.Infra.Data.Repositories
{
    public class EFFindMovie(AppDbContext appDbContext) : IFindRepository<Movie>
    {
        private readonly AppDbContext db = appDbContext;
        public List<Movie> FindAll()
        {
            return [.. db.Movies];
        }

        public List<Movie> FindBy(Expression<Func<Movie, bool>> filter)
        {
            return [.. db.Movies.Where(filter)];
        }
    }
}
