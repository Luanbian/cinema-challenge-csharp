using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.EntityFramework;
using CinemaChallenge.Infra.Data.Exceptions;
using CinemaChallenge.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CinemaChallenge.Infra.Data.Repositories
{
    public class EFFindbyAuth(AppDbContext appDbContext) : IFindRepository<User>
    {
        private readonly AppDbContext db = appDbContext;
        public async Task<List<User>> FindBy(Expression<Func<User, bool>> filter)
        {
            List<User> user = await db.Users.Where(filter).ToListAsync();
            if (user.Count > 0)
            {
                return user;
            } else
            {
                throw new UserNotExists("Usuário não existe");
            }
        }

        public Task<List<User>> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
