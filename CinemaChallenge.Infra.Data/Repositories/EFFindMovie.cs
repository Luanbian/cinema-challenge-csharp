using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.EntityFramework;
using CinemaChallenge.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CinemaChallenge.Infra.Data.Repositories
{
    public class EFFindMovie(AppDbContext appDbContext) : IFindRepository<Movie>
    {
        private readonly AppDbContext db = appDbContext;
        public async Task<List<Movie>> FindAll()
        {
            return await db.Movies.ToListAsync();
        }

        public async Task<List<Movie>> FindBy(Expression<Func<Movie, bool>> filter)
        {
            return await db.Movies.Where(filter).ToListAsync();
        }
    }
}
