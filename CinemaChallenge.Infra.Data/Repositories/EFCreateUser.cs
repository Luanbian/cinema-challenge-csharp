using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.EntityFramework;
using CinemaChallenge.Infra.Data.Exceptions;
using CinemaChallenge.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CinemaChallenge.Infra.Data.Repositories
{
    public class EFCreateUser(AppDbContext appDbContext) : ICreateRepository<User>
    {
        private readonly AppDbContext db = appDbContext;

        public async Task Create(User data)
        {
            User? alreadyExist = await db.Users.FirstOrDefaultAsync(user => user.Email == data.Email);
            if (alreadyExist == null)
            {
                db.Users.Add(data);
                await db.SaveChangesAsync();
            } else
            {
                throw new EmailAlreadyExistsException($"{data.Email} já está sendo usado por um usuário");
            }
        }
    }
}
