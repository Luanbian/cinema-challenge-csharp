using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Infra.Data.Exceptions;
using CinemaChallenge.Infra.Data.Interfaces;

namespace CinemaChallenge.Application.UseCases.Users
{
    public class Login(IFindRepository<User> find, IEncrypter encrypter, IAuthenticate auth) : ILogin
    {
        private readonly IFindRepository<User> repository = find;
        private readonly IEncrypter encrypter = encrypter;
        private readonly IAuthenticate auth = auth;

        public async Task<string> Perform(string email, string password)
        {
            try
            {
                List<User> users = await FindByEmail(email);
                CheckPassword(password, users[0].Password);
                string token = auth.GenerateToken(users[0].Id.ToString());
                return token;
            } catch (UserNotExists ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        private async Task<List<User>> FindByEmail(string email)
        {
            return await repository.FindBy(user => (email == user.Email));
        }

        private void CheckPassword(string password, string hashedPassword)
        {
            bool checkPassword = encrypter.VerifyPassword(password, hashedPassword);
            if (!checkPassword)
            {
                throw new Exception("Senha incorreta");
            }
        }
    }
}
