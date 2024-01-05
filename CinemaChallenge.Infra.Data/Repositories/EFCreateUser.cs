using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.EntityFramework;
using CinemaChallenge.Infra.Data.Exceptions;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Infra.Data.Repositories
{
    public class EFCreateUser(AppDbContext appDbContext) : ICreateRepository<User>
    {
        private readonly AppDbContext db = appDbContext;

        public void Create(User data)
        {
            User? alreadyExist = db.Users.FirstOrDefault(user => user.Email == data.Email);
            if (alreadyExist == null)
            {
                db.Users.Add(data);
                db.SaveChanges();
            } else
            {
                throw new EmailAlreadyExistsException($"{data.Email} já está sendo usado por um usuário");
            }
        }
    }
}
