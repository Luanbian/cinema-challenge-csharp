using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.EntityFramework;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Infra.Data.Repositories
{
    public class EFCreateUser(AppDbContext appDbContext) : ICreateRepository<User>
    {
        private readonly AppDbContext db = appDbContext;

        public void Create(User data)
        {
            db.Users.Add(data);
            db.SaveChanges();
        }
    }
}
